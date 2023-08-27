using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqTakeandSkipMethod
    {
        public static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var ilkBesSayi = sayilar.Take(5);

            Console.WriteLine("İlk Beş Sayı: ");
            foreach(int i in ilkBesSayi) 
            { 
                Console.WriteLine(i); 
            }

            var ilkBesSayiAtla= sayilar.Skip(5);
            Console.WriteLine("Beşinci Sayıdan Sonraki Değerler: ");
            foreach(int i in ilkBesSayiAtla)
            {
                Console.WriteLine(i);
            }
        }
    }
}
