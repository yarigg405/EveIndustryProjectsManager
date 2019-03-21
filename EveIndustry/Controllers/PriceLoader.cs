using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System.Globalization;


namespace EveIndustry.Controllers
{
    public class PriceLoader
    {
        public void LoadPrices()
        {
            var ids = GetItemsIds();
            LoadData(ids);
            Program.dataBase.SaveChanges();
        }

        private List<string> GetItemsIds()
        {
            List<string> itemIds = new List<string>();
            var projects = Program.dataBase.Projects.ToList();

            foreach (var proj in projects)
            {
                AddIdToList(itemIds, proj.Item.Id);

                foreach (var item in proj.ModernisationItems)
                {
                    AddIdToList(itemIds, item.ItemId);
                }

                foreach (var item in proj.ProductionsItems)
                {
                    AddIdToList(itemIds, item.ItemId);
                }
            }

            return itemIds;


        }

        private void AddIdToList(List<string> list, string id)
        {
            if (!list.Contains(id) && id != "")
                list.Add(id);
        }


        private void LoadData(List<string> ids)
        {
            //разбиваем все идшники по мини-массивам до 200 шт (ограничение Get-запроса)
            int maxCount = 198;
            int listsCount = ids.Count / maxCount + 1;
            var lists = new List<string>[listsCount];
            for (int i = 0; i < lists.Length; i++)
            {
                lists[i] = new List<string>();
                lists[i].AddRange(ids.Skip(maxCount * i).Take(maxCount).ToArray());
            }

            foreach (var minilist in lists)
            {
                var url = GetUrl(minilist);
                var document = LoadHtml(url);
                ParseHtmlDocument(document);
            }
        }

        private string GetUrl(List<string> minilist)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"https://api.evemarketer.com/ec/marketstat?typeid=");
            foreach (var id in minilist)
            {
                sb.Append(id);
                sb.Append(",");
            }
            sb.Length--;
            sb.Append($"&regionlimit={Program.regionId}");
            
            return sb.ToString();

        }

        private HtmlDocument LoadHtml(string url)
        {
            WebRequest req = WebRequest.Create(url);
            WebResponse res = req.GetResponse();

            Stream stream = res.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string result = sr.ReadToEnd();
            sr.Close();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(result);

            return htmlDoc;
        }

        private void ParseHtmlDocument(HtmlDocument doc)
        {
            foreach (var node in doc.DocumentNode.SelectNodes("//type"))
            {
                var id = node.GetAttributeValue("id", "type");

                var sellNode = node.ChildNodes["sell"];
                var sellMin = decimal.Parse(sellNode.ChildNodes["min"].InnerText, CultureInfo.InvariantCulture);
                var sellMax = decimal.Parse(sellNode.ChildNodes["max"].InnerText, CultureInfo.InvariantCulture);
                var sellVolume = int.Parse(sellNode.ChildNodes["volume"].InnerText);

                var buyNode = node.ChildNodes["buy"];
                var buyMin = decimal.Parse(buyNode.ChildNodes["min"].InnerHtml, CultureInfo.InvariantCulture);
                var buyMax = decimal.Parse(buyNode.ChildNodes["max"].InnerHtml, CultureInfo.InvariantCulture);
                var buyVolume = int.Parse(sellNode.ChildNodes["volume"].InnerHtml);



                var item = Program.dataBase.Items.FirstOrDefault(i => i.Id == id);
                var order = Program.dataBase.Orders.FirstOrDefault(o => o.Id == id);
                if (order == null)
                {
                    order = new Data.Order();
                    Program.dataBase.Orders.Add(order);                    
                }

                item.Order = order;
                order.Id = id;
                order.Item = item;
                item.Order = order;               

                order.LastModified = DateTime.Now;
                switch (Program.regionId)
                {
                    case "10000002":
                        {
                            order.SellMinJita = sellMin;
                            order.SellMaxJita = sellMax;
                            order.SellVolume = sellVolume;

                            order.BuyMinJita = buyMin;
                            order.BuyMaxJita = buyMax;
                            order.BuyVolume = buyVolume;

                        }
                        break;

                    default: throw new Exception("Region with id "
                        + Program.regionId
                        + " not found");

                }               
            }



        }




    }
}
