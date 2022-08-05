using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIT_HESAP_MAKINESI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *
            *Kullanıcıdan yapmak istediği işlem istenir:
               • Toplama için 1
               • Çıkarma için 2
               • Çarpma için 3
               • Bölme için 4
               • Mod alma için 5
               • Çıkış için 0
               Seçilen işlem 1,2,3 ve 4 için 2 adet double sayı istenir.
               Seçilen işlem 5 için 2 adet integer sayı istenir.
               Kullanıcı sayıları girdikten sonra sonuç ekrana gösterilir.
               Kullanıcı 0 seçene kadar işlem istenmeye devam edilir.
               Kullanıcının 0 seçmesi durumunda program sonlandırılır.
               ! Bölme işleminde bölen 0 olamaz kontrolü yapılmalıdır.
               ! İşlem seçimi bölümünde mevcut seçenekler dışında bir değer girilemez kontrolü yapılmalıdır.
               ! Sayı girilen yerlerde string veya char değer girilemez. Girilmesi durumunda kullanıcı uyarılır ve
               yalnızca yanlış girilen değer kullanıcıdan doğrusu girilene kadar tekrar istenir. 
            *
            *
            */
            MENU:
            Console.WriteLine("*****BASİT HESAP MAKİNESİ****");
            Console.WriteLine("Toplama İşlemi için 1");
            Console.WriteLine("Çıkarma İşlemi için 2");
            Console.WriteLine("Çarpma İşlemi için 3");
            Console.WriteLine("Bölme İşlemi için 4");
            Console.WriteLine("Mod alma İşlemi için 5");
            Console.WriteLine("ÇIKIŞ için 0");

            char secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '0':
                    Console.WriteLine("Programdan çıkılıyor");
                    Environment.Exit(0);
                    break;
                case '1':
                    sayi1:
                    Console.WriteLine("1. Sayıyı Girniz");
                    //double sayi1 = Convert.ToDouble(Console.ReadLine());
                    string sayi1 = Console.ReadLine();
                    double number;
                    bool result1 = double.TryParse(sayi1, out number);
                    if (result1==false)
                    {
                        goto sayi1;
                    }

                    sayi2:
                    Console.WriteLine("2. Sayıyı Girniz");
                    //double sayi2 = Convert.ToDouble(Console.ReadLine());
                    string sayi2 = Console.ReadLine();
                    double number2;
                    bool result2 = double.TryParse(sayi2, out number2);
                    if (result2==false)
                    {
                        goto sayi2;
                    }
                    
                    AritmetikIslemler toplamaIslemi = new AritmetikIslemler();
                    double toplam = toplamaIslemi.topla(Convert.ToDouble(sayi1), Convert.ToDouble(sayi2));
                    
                    Console.WriteLine("Toplama İşlemi Sonucu:{0}", toplam);
                    break;
                
                case '2':
                    sayi3:
                    Console.WriteLine("1. Sayıyı Girniz");
                    string sayi3 = Console.ReadLine();
                    double number3;
                    bool result3 = double.TryParse(sayi3, out number3);
                    if (result3 == false)
                    {
                        goto sayi3;
                    }

                    sayi4:
                    Console.WriteLine("2. Sayıyı Girniz");
                    string sayi4 = Console.ReadLine();
                    double number4;
                    bool result4 = double.TryParse(sayi4, out number4);
                    if (result4 == false)
                    {
                        goto sayi4;
                    }


                    AritmetikIslemler cikarmaIslemi = new AritmetikIslemler();
                    double fark = cikarmaIslemi.cikar(Convert.ToDouble(sayi4), Convert.ToDouble(sayi4));
                    Console.WriteLine("Çıkarma İşlemi Sonucu:{0}", fark);
                    break;

                case '3':
                    sayi5:
                    Console.WriteLine("1. Sayıyı Girniz");
                    string sayi5 = Console.ReadLine();
                    double number5;
                    bool result5 = double.TryParse(sayi5, out number5);
                    if (result5 == false)
                    {
                        goto sayi5;
                    }

                    sayi6:
                    Console.WriteLine("2. Sayıyı Girniz");
                    string sayi6 = Console.ReadLine();
                    double number6;
                    bool result6 = double.TryParse(sayi6, out number6);
                    if (result6 == false)
                    {
                        goto sayi6;
                    }

                    AritmetikIslemler bolmeIslemi = new AritmetikIslemler();
                    double bolum = bolmeIslemi.bolme(Convert.ToDouble(sayi5), Convert.ToDouble(sayi6));
                    Console.WriteLine("Bolme İşlemi Sonucu:{0}", bolum);
                    break;

                case '4':
                    sayi7:
                    Console.WriteLine("1. Sayıyı Girniz");
                    string sayi7 = Console.ReadLine();
                    double number7;
                    bool result7 = double.TryParse(sayi7, out number7);
                    if (result7 == false)
                    {
                        goto sayi7;
                    }

                    sayi8:
                    Console.WriteLine("2. Sayıyı Girniz");
                    string sayi8 = Console.ReadLine();
                    double number8;
                    bool result8 = double.TryParse(sayi8, out number8);
                    if (result8 == false)
                    {
                        goto sayi8;
                    }


                    AritmetikIslemler carpmaIslemi = new AritmetikIslemler();
                    double carpim = carpmaIslemi.carp(Convert.ToDouble(sayi7),Convert.ToDouble(sayi8));
                    Console.WriteLine("Çarpma işlemi Sonucu:{0}", carpim);
                    break;
                case '5':
                    sayi9:
                    Console.WriteLine("1. Sayıyı Girniz");
                    string sayi9 = Console.ReadLine();
                    int number9;
                    bool result9 = int.TryParse(sayi9, out number9);
                    if (result9 == false)
                    {
                        goto sayi9;
                    }

                    sayi10:
                    Console.WriteLine("2. Sayıyı Girniz");
                    string sayi10 = Console.ReadLine();
                    int number10;
                    bool result10 = int.TryParse(sayi10, out number10);
                    if (result10 == false)
                    {
                        goto sayi10;
                    }
                    AritmetikIslemler modAlmaIslemi = new AritmetikIslemler();
                    double sonuc = modAlmaIslemi.mod(Convert.ToInt32(sayi9), Convert.ToInt32(sayi10));
                    Console.WriteLine("Mod Alma işlemi Sonucu:{0}", sonuc);
                    break;
                default:
                    Console.Clear();
                    Console.Write("Yanlış Seçim Yaptınız. Tekrar Deneyiniz!");
                    goto MENU;
                    break;
            }

            DEVAMSECIM:
            Console.Write("Yeniden işlem yapmak ister misiniz? (EVET:E HAYIR:H)");
            char devamSec = Convert.ToChar(Console.ReadLine());
            if (devamSec == 'E' || devamSec == 'e')
            {
                Console.Clear();
                goto MENU;
            }
            else if (devamSec == 'H' || devamSec == 'h')
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

        public class AritmetikIslemler
        {
            public double topla(double sayi1, double sayi2)
            {
                double toplam = sayi1 + sayi2;
                return toplam;
            }

            public double cikar(double sayi1, double sayi2)
            {
                double fark = sayi1 - sayi2;
                return fark;
            }

            public double carp(double sayi1, double sayi2)
            {
                double carpim = sayi1 * sayi2;
                return carpim;
            }

            public double bolme(double sayi1, double sayi2)
            {

                double bolum = sayi1 / sayi2;

                return bolum;
            }

            public int mod(int sayi1, int sayi2)
            {
                int mod = sayi1 % sayi2;
                return mod;
            }
        }
    }
}
