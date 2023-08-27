using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MinandMax
    {
        public static void Main()
        {
            int[] sayilar = { 5, 35, 45, 98, 78, 1, 63, 72 };

            var MinSayi = sayilar.Min();
            Console.WriteLine("Minimum Sayı: " + MinSayi);

            var MaxSayi = sayilar.Max();
            Console.WriteLine("Maximum Sayı: " + MaxSayi);


        }
        


    }
}
