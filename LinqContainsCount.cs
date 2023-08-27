using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqContainsCount
    {
        public static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50 };

            var varMi =(from sayi in sayilar select sayi).Contains(70); //dizide 70 var mı varsa true yoksa false

            Console.WriteLine(varMi);

            var kacDeger= sayilar.Count();
            Console.Write("Değer Sayısı");
            Console.WriteLine(kacDeger);
        }
    }
}
