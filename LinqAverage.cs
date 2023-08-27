using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqAverage
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 6, 9, 23, 45, 56, 78 };

            double ortalama= list.Average();

            Console.WriteLine("Ortalama: "+ortalama);
        }
    }
}
