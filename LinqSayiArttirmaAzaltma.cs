using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqSayiArttirmaAzaltma
    {
        public static void Main()
        {
            int[] sayilar = { 2, 5, 7, 8, 34, 21, 52, 72, 0 };

            Console.WriteLine("Sayı Dizimiz: ");
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }

            var arttir=
                from sayi in sayilar
                select sayi+5;
            Console.WriteLine("Arttırılmış sayılar: ");
            foreach( var sayi in arttir)
            {
                Console.WriteLine(sayi);
            }

            var azalt=
                from sayi in sayilar
                select sayi-2;
            Console.WriteLine("Azaltılmış Sayılar: ");
            foreach(var sayi in azalt)
            {
                Console.WriteLine(sayi);
            }
        }
        
        
    }
}
