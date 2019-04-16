using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace EveIndustry.Controllers
{
    public static class Extensions
    {
        public static string ToMoney(this decimal value)
        {
            return value.ToString("N2");
        }

        public static List<string[]> ParseText(string input)
        {
            var result = new List<string[]>();

            var separators = new string[]
                {
                    "ISK",
                    "\n",
                };
           

            foreach (var str in input.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                var array = str.Split('\t');
                var name = array[0].Replace("*", "");
                var count = array[1];

                if (name != "")
                    result.Add(new string[] { name, count });
            }

            return result;

        }

        public static int ParseCount(string str)
        {
            var regex = new Regex(@"[^\d]");
            var str1 = regex.Replace(str, "");

            try
            {
                return int.Parse(str1);
            }

            catch
            {
               throw new Exception("Parsing error with:\n#" + str1 + "#");                
            }

        }


        private static string GetString(string input, string from, string to = "")
        {
            //получить определенный фрагмент из текста по формату "from...to"
            StringBuilder pattern = new StringBuilder();
            pattern.Append("(").Append(from).Append((to == "" ? ")(.*)" : ")(.*?)"));
            if (to != "")
                pattern.Append("(").Append(to).Append(")");

            string result;

            if (to == "")
            {
                result = Regex.Match(input, pattern.ToString()).Value;
                result = result.Replace(from, "");
            }
            else
            {
                result = Regex.Match(input, pattern.ToString(), RegexOptions.Singleline).Value;
                result = result.Replace(from, "").Replace(to, "");
            }


            return result;
        }



    }

}
