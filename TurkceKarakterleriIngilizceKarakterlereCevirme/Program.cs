using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkceKarakterleriIngilizceKarakterlereCevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime, yeniKelime;
            Console.Write("İngilizce bir kelime giriniz?");
            kelime = Console.ReadLine();

            yeniKelime = kelime;

            yeniKelime = yeniKelime.Replace('İ', 'i');
            yeniKelime = yeniKelime.Replace('Ç', 'c');
            yeniKelime = yeniKelime.Replace('ç', 'C');
            yeniKelime = yeniKelime.Replace('Ş', 'S');
            yeniKelime = yeniKelime.Replace('ş', 'S');
            yeniKelime = yeniKelime.Replace('Ğ', 'G');
            yeniKelime = yeniKelime.Replace('ğ', 'g');
            yeniKelime = yeniKelime.Replace('Ü', 'U');
            yeniKelime = yeniKelime.Replace('ü', 'u');
            yeniKelime = yeniKelime.Replace('Ö', 'O');
            yeniKelime = yeniKelime.Replace('ö', 'o');

            if (kelime!=yeniKelime)
            {
                Console.WriteLine("Türkçe karakterler üzerinde düzeltmeler yapılmıştır.");
                Console.Write("Girilen Kelime:{0} Düzeltilen Hali:{1}", kelime, yeniKelime);
            }
            Console.ReadKey();
        }
    }
}
