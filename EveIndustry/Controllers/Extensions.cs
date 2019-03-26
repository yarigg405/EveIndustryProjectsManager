using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveIndustry.Controllers
{
   public static class Extensions
    {
        public static string ToMoney(this decimal value)
        {
            return value.ToString("N2");
        }
       
    }
}
