using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string yazilacakMetin = "Merhaba Türkiye";
            metinYaz(yazilacakMetin);
            Console.ReadKey();
        }
        public static void metinYaz(string metin)
        {
            for (int i = 1; i <=5 ; i++)
            {
                Console.WriteLine(metin);
            }
        }
    }
}
