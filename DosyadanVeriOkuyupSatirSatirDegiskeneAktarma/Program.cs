using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadanVeriOkuyupSatirSatirDegiskeneAktarma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = @"c:\c# dersleri\konular.txt";
            string[] satirlar = System.IO.File.ReadAllLines(dosyaYolu, Encoding.GetEncoding("windows-1254"));

            foreach (var satir in satirlar)
            {
                Console.WriteLine(satir);
            }
            Console.ReadKey();
        }
    }
}
