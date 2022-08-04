using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseBasamakYapisi
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi;
            Console.Write("Bir sayı giirniz?");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 0)
            {
                Console.Write("Sayı negatiftir.");
            } else if(sayi > 0)
            {
                Console.Write("Sayı pozitiftir.");
            } else
            {
                Console.Write("Sayı sıfıra eşittir");
            }

            Console.ReadKey();
        }
    }
}
