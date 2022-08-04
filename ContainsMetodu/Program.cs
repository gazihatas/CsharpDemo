using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Contains Metodu => String türünden bir veri içerisinde :
             * tek bir karakterlik char bir veri string türünde arama yapabiliriz.
             * Arama yaptığımız ifade varsa true yoksa false depğeri döndürür.
             * 
             */

            string ad, soyad;
            bool arama_ad, arama_soyad;
            Console.Write("Adınızı giriniz?");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz?");
            soyad = Console.ReadLine();
            arama_ad = rakamAra(ad);
            arama_soyad = rakamAra(soyad);
            if (arama_ad == true)
                Console.Write("Ad içerisinde rakam kullanılmamalı!");
            if (arama_soyad == true)
                Console.Write("Soyad içerisinde rakam kullanılmamalı");
            if (arama_ad == false && arama_soyad == false)
                Console.Write("Kayıt işlemi başarı ile tamamlanmıştır.");
            Console.ReadKey();

        }

        public static bool rakamAra(string aranacakMetin)
        {
            if (aranacakMetin.Contains('0'))
                return true;
            else if (aranacakMetin.Contains('1'))
                return true;
            else if (aranacakMetin.Contains('2'))
                return true;
            else if (aranacakMetin.Contains('3'))
                return true;
            else if (aranacakMetin.Contains('4'))
                return true;
            else if (aranacakMetin.Contains('5'))
                return true;
            else if (aranacakMetin.Contains('6'))
                return true;
            else if (aranacakMetin.Contains('7'))
                return true;
            else if (aranacakMetin.Contains('8'))
                return true;
            else if (aranacakMetin.Contains('9'))
                return true;
            else
                return false;

        }
    }
}
