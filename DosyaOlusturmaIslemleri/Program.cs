using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaOlusturmaIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dosya Oluşturma

            string dosyaAdi = "deneme.txt";
            string dosyaYolu = @"c:\deneme";
            string hedefYol = System.IO.Path.Combine(dosyaYolu, dosyaAdi);

            if (System.IO.File.Exists(hedefYol))
            {
                Console.Write("Dosya zatenn mevcuttur.");
            }
            else
            {
                System.IO.File.Create(hedefYol);
            }
            Console.ReadKey();
        }
    }
}
