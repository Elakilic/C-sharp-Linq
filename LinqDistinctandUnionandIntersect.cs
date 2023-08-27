using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqDistinctandUnionandIntersect
    {
        public static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, };

            var degertekle = sayilar.Distinct();
            Console.WriteLine("Birbirinden farklı sayılarımız:");
            foreach (var item in degertekle) 
            { 
                Console.WriteLine(item); 
            }

            int[] sayilar1 = { 1, 2, 3, 4, 5, 6, };
            int[] sayilar2 = { 1, 2, 3, 7, 8, 9, 10 };

            var union = sayilar1.Union(sayilar2); //birleşim
            Console.WriteLine("İki dizi birleştirildi.");
            foreach(var item in union)
            {
                Console.WriteLine(item);
            }
            var intersect = sayilar1.Intersect(sayilar2);
            Console.WriteLine("Keşisen Sayılarımız:");
            foreach( var item in intersect)
            {
                Console.WriteLine(item);
            }
        }
    }
}
