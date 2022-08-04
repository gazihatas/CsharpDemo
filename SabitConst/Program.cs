using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabitConst
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * const türünde bir veri tanımlandığı zaman onun değeri tanımlandığı satırda verilmek zorundadır.
             */
              
            const double pi = 3.14;
            double yaricap;
            double alan;

            Console.Write("Yarıçap değerini giriniz?");
            yaricap = Convert.ToDouble(Console.ReadLine());
            alan = pi * (yaricap * yaricap);
            Console.Write("Alan:{0}", alan);
            Console.ReadKey();

        }
    }
}
