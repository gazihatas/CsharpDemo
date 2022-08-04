using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int ortalama = 45;
            if (ortalama < 50)
                Console.Write("Kaldı");
            else
                Console.Write("Geçti");
            Console.ReadKey();


            //klavyeden girilen bbir sayının tek sayımı çif sayımı
            int sayi, sonuc;
            Console.Write("Bir sayı giriniz?");
            sayi = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi % 2;
            if (sonuc == 0)
                Console.WriteLine("Girilen sayı çift sayııdır.");
            else
                Console.Write("Girilen sayı tek sayıdır.");

            Console.ReadKey();


            //VkI
            int boy, kilo;
            Console.Write("Boyunuzu Giriniz: ");
            boy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToInt32(Console.ReadLine());

            if (boy > 167 && kilo < 80)
                Console.Write("Başvuru koşulları sağlanıyor");
            else
                Console.Write("Başvuru koşulları sağlanmıyor");
            Console.ReadKey();

            string kullaniciAdi, sifre;
            Console.Write("Kullanıcı adınızı giriniz");
            kullaniciAdi = Console.ReadLine();
            Console.Write("Şifrenizi Giriniz");
            sifre = Console.ReadLine();
            if (kullaniciAdi != "Ankara" || sifre!= "0606")
                Console.Write("Kullanıcı adı veya şifre hatalı!");
            else
                Console.Write("Giriş Başarılı, hoşgeldiniz");

            Console.ReadKey();

            int kenar1, kenar2, kenar3;
            
            Console.WriteLine("Kenar1 değerini giriniz?");
            kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kenar 2  değerini giriniz?");
            kenar2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kenar 3 değerini giriniz?");
            kenar3 = Convert.ToInt32(Console.ReadLine());

            if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
            {
                Console.Write("Üçgen ikizkenar üçgendir");
            }
            else
                Console.WriteLine("Üçgen ikizkenar üçgen değildir.");
            Console.ReadKey();


        }
    }
}
