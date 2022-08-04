using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalsorSilmeIslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KLASOR SİLME İŞLEMİ

            string klaasorYolu = @"c:\NOTLARIM";
            if (System.IO.Directory.Exists(klaasorYolu))
            {
                System.IO.Directory.Delete(klaasorYolu, true);
                Console.Write("Klasör tüm içeriğiyle birlikte silindi.");
            }
            else
            {
                Console.Write("Silinmek istenilen klasör mevcut değil!");
            }
            Console.ReadKey();
        }
    }
}
