using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogrenciNo, ad, soyad, adres;

            Console.Write("Öğrenci numaranızı giriniz?");
            ogrenciNo = Console.ReadLine();

            Console.Write("Adıznı Giriniz?");
            ad = Console.ReadLine();

            Console.Write("Soyadınızı Giriniz?");
            soyad = Console.ReadLine();

            Console.Write("Adresinizi Giriniz?");
            adres = Console.ReadLine();
            if (ogrenciNo == "" || ad == "" || adres == "")
                Console.Write("Girilen Bilgilerde eksiklik var");
            else
                Console.Write("Kayıt işlemi başarı ile tamamlanmıştır.");
            Console.ReadKey();


            //----------------------------------------------------

            int vize1, vize2, final;

            Console.Write("1. Vize notunuzu giriniz");
            vize1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Vize notunuzu giriniz");
            vize2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final notunuzu giriniz?");
            final = Convert.ToInt32(Console.ReadLine());

            if (vize1 >= 50 && vize2 >= 50 && final >= 50)
                Console.WriteLine("Dersi başarı ile tamamladınız");
            else
                Console.WriteLine("Yaza okuluna kaldınız");

            Console.ReadKey();


            //--------------------------------------------------
            double sayi1, sayi2, sonuc;
            char secim;

            Console.Write("1. sayıyı giriniz?");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı giriniz?");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("1-Toplama 2-Çıkarma 3-Çarpma 4 -bölme seçiminizi giriniz?");
            secim = Convert.ToChar(Console.ReadLine());

            if (secim == '1')
            {
                sonuc = sayi1 + sayi2;
                Console.Write("Toplama Sonucu {0}", sonuc);
            }

            if (secim == '2')
            {
                sonuc = sayi1 - sayi2;
                Console.Write("Çıkarma Sonucu {0}", sonuc);
            }

            if (secim == '3')
            {
                sonuc = sayi1 * sayi2;
                Console.Write("Çarpma Sonucu {0}", sonuc);
            }

            if (secim == '4')
            {
                sonuc = sayi1 / sayi2;
                Console.Write("Bölme Sonucu {0}", sonuc);
            }
            Console.ReadKey();

        }
    }
}
