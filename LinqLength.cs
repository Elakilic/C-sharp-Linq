using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqLength
    {
        public static void Main(string[] args)
        {
            string[] sehirler = { "diyarbakır", "adana", "antalya", "hatay", "muş", "bolu" };

            var liste =
                from s in sehirler
                orderby s.Length
                select s;
            Console.WriteLine("Uzunluğuna göre listeli şehirler: ");
            foreach (var s in liste)
            {
                Console.WriteLine(s);
            }
        }
    }
}
