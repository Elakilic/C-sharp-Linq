using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqtoUppertoLower
    {
        public static void Main()
        {
            string[] meyve = { "eLmA", "ArMUt", "mUz", "çİLeK", "ManGO" };

            var yazilis =
                from m in meyve
                select new { Buyut = m.ToUpper(), Kucult = m.ToLower() };
            foreach (var yazi in yazilis)
            {
                Console.WriteLine("Büyüt: " +yazi.Buyut + " Küçült: " +yazi.Kucult);
            }
        }
    }
}
