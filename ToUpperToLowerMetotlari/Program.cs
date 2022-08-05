using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpperToLowerMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ToUpper() => string ifadeyi BÜYÜK harfe çevirir.
             */

            string ilAdi;
            Console.Write("İl adını giriniz?");
            ilAdi = Console.ReadLine();
            switch (ilAdi.ToUpper())
            {
                case "ANKARA":
                    Console.Write("Plaka Kodu:06");
                    break;
                case "İSTANBUL":
                    Console.Write("Plaka Kodu:34");
                    break;
                default:
                    Console.Write("İl Bulunamadı.");
                    break;
            }
            Console.ReadKey();

            /*
            *ToLower() => string ifadeyi küçük harfe çevirir.
            */

            string ilAdin;
            Console.Write("İl adını giriniz?");
            ilAdin = Console.ReadLine();
            switch (ilAdin.ToLower())
            {
                case "ankara":
                    Console.Write("Plaka Kodu:06");
                    break;
                case "istanbul":
                    Console.Write("Plaka Kodu:34");
                    break;
                default:
                    Console.Write("İl Bulunamadı.");
                    break;
            }
            Console.ReadKey();

        }
    }
}
