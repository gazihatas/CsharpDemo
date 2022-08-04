using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            //klavyeden girilen 5 adet sayının toplanıp ekrana yazılması

            /*
            int sayac = 1;
            int sayi = 0;
            int toplam = 0;
            while (sayac<=5)
            {
                Console.Write("{0}. sayıyı giriniz", sayac);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                sayac++;
            }
            Console.Write("Sayıların Toplamı:{0}", toplam);
            Console.ReadKey();
            */


            //kullanıcı klavyeden kaç adet sayı gireceğini belirtecek
            //bu sayoıların ortalaması while döngüsü ile hesaplanacak

            int sayac = 1;
            int adet = 0;
            int sayi = 0;
            int toplam = 0;
            int ortalama = 0;
            Console.WriteLine("Kaç adet sayı gireceksiniz");
            adet = Convert.ToInt32(Console.ReadLine());

            while (sayac<=adet)
            {
                Console.Write("{0}. Sayıyı Giriniz?",sayac);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                sayac++;
            }
            ortalama = toplam / adet;
            Console.Write("Sayıların Ortalaması:{0}", ortalama);
            Console.ReadKey();
        }

    }
}
