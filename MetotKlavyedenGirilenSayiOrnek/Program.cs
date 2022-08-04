using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotKlavyedenGirilenSayiOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            Console.WriteLine("1. Sayıyı Girniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Girniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            DORTISLEMSEC:
            Console.Write("Seçiminizi Yapınız? (Toplama:1 Çıkarma:2 Bölme:3 Çarpma:4)");
            char dortIslemSecim = Convert.ToChar(Console.ReadLine());
            switch (dortIslemSecim)
            {
                case '1':
                    dortIslem toplamaIslemi = new dortIslem();
                    double toplam = toplamaIslemi.topla(sayi1, sayi2);
                    Console.WriteLine("Toplama İşlemi Sonucu:{0}", toplam);
                    break;
                case '2':
                    dortIslem cikarmaIslemi = new dortIslem();
                    double fark =  cikarmaIslemi.cikar(sayi1, sayi2);
                    Console.WriteLine("Çıkarma İşlemi Sonucu:{0}", fark);
                    break;
                case '3':
                    dortIslem bolmeIslemi = new dortIslem();
                    double bolum = bolmeIslemi.bol(sayi1, sayi2);
                    Console.WriteLine("Bolme İşlemi Sonucu:{0}", bolum);
                    break;
                case '4':
                    dortIslem carpmaIslemi = new dortIslem();
                    double carpim = carpmaIslemi.carp(sayi1, sayi2);
                    Console.WriteLine("Toplama Sonucu:{0}", carpim);
                    break;
                default:
                    Console.Clear();
                    Console.Write("Yanlış Seçim Yaptınız. Tekrar Deneyiniz!");
                    goto DORTISLEMSEC;
                break;
            }

            DEVAMSECIM:
            Console.Write("Yeniden işlem yapmak ister misiniz? (EVET:E HAYIR:H)");
            char devamSec = Convert.ToChar(Console.ReadLine());
            if (devamSec=='E' || devamSec =='e')
            {
                Console.Clear();
                goto BASADON;
            }
            else if (devamSec=='H' || devamSec=='h')
            {
                Console.Write("İyi günler.");
                //Console.ReadKey();
            }
            else
            {
                Console.Write("Yanlış seçim yaptınız. Tekrar deneyiniz!");
                goto DEVAMSECIM;
            }
        }

        class dortIslem
        {
            public double topla(double sayi1, double sayi2)
            {
                return (sayi1 + sayi2);
            }

            public double cikar(double sayi1, double sayi2)
            {
                return (sayi1 - sayi2);
            }
            public double bol(double sayi1, double sayi2)
            {
                return (sayi1 / sayi2);
            }

            public double carp(double sayi1, double sayi2)
            {
                return (sayi1 * sayi2);
            }
        }
    }
}
