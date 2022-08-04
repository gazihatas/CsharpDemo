using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyadanVeriOkuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DOSYA dan VERİ OKUMA İŞLEMLERİ
            string dosyaYolu = @"c:\c# dersleri\degiskenler.txt";
            string metin = System.IO.File.ReadAllText(dosyaYolu,Encoding.GetEncoding("windows-1254"));
            Console.Write(metin);
            Console.ReadKey();
        }
    }
}
