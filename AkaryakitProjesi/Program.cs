using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaryakitProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Akaryakıt türleri
            double dizel = 3.12;
            double benzin = 3.28;
            double lpg = 1.78;

            //depolar
            double dizelTank  = 1000;
            double benzinTank = 1000;
            double lpgTank = 1000;

            double satisMiktari = 0;

            //Menu tanımları
            char anaMenuSecim = '0';
            char altMenuSecim = '0';
            char akaryakitFiyatGuncelle = '0';
            char akaryakitSatisTipi = '0';

            //ANA MENÜ OLUŞTURMA
            MENU:
            Console.WriteLine("Akaryakıt Satış Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Birim Fiyat Göster");
            Console.WriteLine("2-Birim Fiyat Güncelle");
            Console.WriteLine("3-Akaryakıt Satışı Takip");
            Console.WriteLine("4-Depo Durumunu Göster");
            Console.WriteLine("5-Toplam Satışları Göster");
            Console.WriteLine("6-Çıkış");


            Console.Write("Seçiminizi Yapınız [1,2,3,4,5,6]:");
            anaMenuSecim = Convert.ToChar(Console.ReadLine());

            if (anaMenuSecim=='1')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:1");
                Console.WriteLine("---Birim Fiyatlar Listesi---");
                Console.WriteLine("Dizel (D):{0} TL/Litre",dizel);
                Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                Console.WriteLine("LPG (L):{0} TL/Litre", lpg);

                ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı KAPAT]");
                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim=='1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim=='2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 Seçenekleri Dışında Yanlış Seçim Yaptınız");
                    goto ALTMENU;   
                }
            }
            else if (anaMenuSecim=='2')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiniz:2");
                Console.WriteLine("---Birim Fiyatlar Güncelleme---");
                AKARYAKITTIPI:
                Console.WriteLine("Akaryakıt Tipini Seçin [D,B,L]");
                akaryakitFiyatGuncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitFiyatGuncelle == 'D' || akaryakitFiyatGuncelle == 'd')
                {
                    Console.WriteLine("Dizel (D):{0} TL/Litre", dizel);
                    Console.Write("Dizel Yakıt İçin Yeni Fiyat Giriniz:");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Dizel (D):{0} TL/Litre",dizel);
                }
                else if (akaryakitFiyatGuncelle == 'B' || akaryakitFiyatGuncelle == 'b')
                {
                    Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                    Console.Write("Benzin Yakıt İçin Yeni Fiyat Giriniz:");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Benzin (B):{0} TL/Litre", benzin);
                }
                else if (akaryakitFiyatGuncelle == 'L' || akaryakitFiyatGuncelle == 'l')
                {
                    Console.WriteLine("LPG (L):{0} TL/Litre", lpg);
                    Console.Write("LPG Yakıt İçin Yeni Fiyat Giriniz:");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("LPG (L):{0} TL/Litre", lpg);
                }
                else
                {
                    Console.WriteLine("[D,B,L] dışında hatalı seçim yaptınız!");
                    goto AKARYAKITTIPI;
                }
                ALTMENU:
                Console.Write("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı KAPAT]");
                altMenuSecim = Convert.ToChar(Console.ReadLine());
                if (altMenuSecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altMenuSecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 Seçenekleri Dışında Yanlış Seçim Yaptınız");
                    goto ALTMENU;
                }
            }
            else if (anaMenuSecim=='3')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:3");
                Console.WriteLine("--Akaryakıt Satış İşlemleri");
                AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt Tipini Seçin [D,B,L]");
                akaryakitSatisTipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitSatisTipi=='D' || akaryakitSatisTipi == 'd')
                {
                    Console.WriteLine("Yakıt tankında hiç dizel yakıt kalmamıştır.");
                    goto MENU;
                }
                else
                {
                    Console.Write("Ne kadarlık dizel yakıt alacaksınız:");
                    satisMiktari = Convert.ToDouble(Console.ReadLine());
                    if (dizelTank<satisMiktari)
                    {
                        Console.WriteLine("Yakıt tankında {0} litre dizel yakıt vardır! İşlem yapılamadı!", dizelTank);
                        goto MENU;
                    }
                    else if (satisMiktari<=dizelTank)
                    {
                        dizelTank = dizelTank - satisMiktari;
                        Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                        Console.Write("Yakıt tankında {0} litre dizel yakıt kaldı.",dizelTank);
                    }
                }
                if (akaryakitSatisTipi == 'B' || akaryakitSatisTipi == 'b')
                {
                    Console.WriteLine("Yakıt tankında hiç benzin yakıt kalmamıştır.");
                    goto MENU;
                }
                else
                {
                    Console.Write("Ne kadarlık benzin yakıt alacaksınız:");
                    satisMiktari = Convert.ToDouble(Console.ReadLine());
                    if (benzinTank < satisMiktari)
                    {
                        Console.WriteLine("Yakıt tankında {0} litre benzin yakıt vardır! İşlem yapılamadı!", benzinTank);
                        goto MENU;
                    }
                    else if (satisMiktari <= benzinTank)
                    {
                        benzinTank = benzinTank - satisMiktari;
                        Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                        Console.Write("Yakıt tankında {0} litre benzin yakıt kaldı.", benzinTank);
                    }
                }
                if (akaryakitSatisTipi == 'L' || akaryakitSatisTipi == 'd')
                {
                    Console.WriteLine("Yakıt tankında hiç lpg yakıt kalmamıştır.");
                    goto MENU;
                }
                else
                {
                    Console.Write("Ne kadarlık lpg yakıt alacaksınız:");
                    satisMiktari = Convert.ToDouble(Console.ReadLine());
                    if (lpgTank < satisMiktari)
                    {
                        Console.WriteLine("Yakıt tankında {0} litre lpg yakıt vardır! İşlem yapılamadı!", lpgTank);
                        goto MENU;
                    }
                    else if (satisMiktari <= lpgTank)
                    {
                        lpgTank = lpgTank - satisMiktari;
                        Console.WriteLine("Yakıt dolumu tamamlanmıştır.");
                        Console.Write("Yakıt tankında {0} litre lpg yakıt kaldı.", lpgTank);
                    }
                }
            }

            Console.ReadKey();


        }
    }
}
