using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EveIndustry.Data
{
    public class Order
    {      
        public string Id { get; set; }
        public Item Item { get; set; }

        public decimal BuyMaxJita { get; set; }
        public decimal BuyMinJita { get; set; }
        public int BuyVolume { get; set; }

        public decimal SellMaxJita { get; set; }
        public decimal SellMinJita { get; set; }
        public int SellVolume { get; set; }

        public DateTime LastModified { get; set; }


        public Order()
        {

        }

    }
}
