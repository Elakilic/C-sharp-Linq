using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinqSayiKarsilastirma
    {
        public static void Main(string[] args)
        {
            int[] sayilar1 = { 1, 3, 5, 7, 9 };
            int[] sayilar2 = { 1, 5, 8, 7, 22 };

            var kiyas=
                from bir in sayilar1
                from iki in sayilar2
                where bir< iki
                select new { bir, iki }; //verileri anonim tipe atıyoruz.
            foreach ( var kys in kiyas ) 
            {
                Console.WriteLine("sonuç " + kys.bir +  " < " + kys.iki );
            }
            
        }
    }
}
