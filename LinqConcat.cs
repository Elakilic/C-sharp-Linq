using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqConcat
    {
        public static void Main(string[] args) 
        {
            List<int> list1 = new List<int>() { 1, 4, 6, 8, 12, 15 };
            List<int> list2 = new List<int>() { 3, 5, 7, 9, 11, 13 };

            var sayilarım = list1.Concat(list2);

            foreach(var i in sayilarım)
            {
                Console.WriteLine(i);
            }



        }   
    }
}
