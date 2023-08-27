using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqOfType
    {
        public static void Main(string[] args)
        {
            object[] objects = { "bir ", "iki", 3.3, 4.6, "pazar", 78 };
            
            var doubleSayilar= objects.OfType<double>();
            Console.WriteLine("objects dizisindeki double sayılar: ");
            foreach(var i  in doubleSayilar)
            {
                Console.WriteLine(i);
            }
            var intSayilar= objects.OfType<int>();
            Console.WriteLine("objects dizisindeki integer sayılar: ");
            foreach (var i in intSayilar)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
