using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //şart en sonda yazılır
            //do ifadesindeki komutlar en az 1 defa çalkışır
            //biz programda bazı kodların en az 1 kez çalışmasını istiyorsak do while kullanırız.

            /*
            int sayac = 1;
            do
            {
                // Bu kısma yazılan kod en az 1 kez çakışır.
                Console.WriteLine(sayac);
                sayac++;
            } while (sayac<=5);
            Console.ReadKey();
            */

            //do while ile kontrol uygulaması

            string kad = "admin", ksifre = "123";
            string kullaniciAd, kullaniciSifre;
            int hak = 3;
            do
            {
                Console.Write("Kullanıcı adını giriniz?");
                kullaniciAd = Console.ReadLine();

                Console.Write("Şifrenizi giriniz?");
                kullaniciSifre = Console.ReadLine();
                if (kullaniciAd==kad && kullaniciSifre==ksifre)
                {
                    Console.Write("Hoşgeldiniz...");
                }
                else
                {
                    hak--;
                    if (hak==0)
                    {
                        Console.Write("3 defada doğru kullanıcı adı ve şifresini giremediniz. Müşteri Hizmetlerini Arayın");
                    }
                }
            } while ((kullaniciAd!=kad || kullaniciSifre!=ksifre) && hak!=0);
            Console.ReadKey();
        }
    }
}
