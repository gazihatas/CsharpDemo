using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden 0 değeri girilene kadar öncesinde igirlen sayıların toplamını ekrana yazdıran 

            /*
            int sayi;
            int toplam = 0;
            do
            {
                Console.Write("Bir sayı giriniz?");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            } while (sayi!=0);
            Console.WriteLine("Sayıların Toplamı:{0}", toplam);
            Console.ReadKey();

            */

            //Rastgele sayı üretilip tahmin edilmesini sağlayan ıuygulama

            Random rnd = new Random();
            int uretilenSayi = rnd.Next(20, 50);
            int sayi;
            int hak = 5;

            //Test aşamasında olduğu için üretilen sayı gösterilmiştir.
            Console.WriteLine("Üretilen Sayı:{0}", uretilenSayi);

            do
            {
                Console.Write("Bir tahminde bulununuz?");
                sayi = Convert.ToInt32(Console.ReadLine());
                hak--;
                if (sayi==uretilenSayi)
                {
                    Console.Write("Tebrikler...");
                }
                else if (sayi<uretilenSayi)
                {
                    Console.Write("Sayı büyültünüz!");
                }
                else if (sayi>uretilenSayi)
                {
                    Console.Write("Sayıyı Küçültünüz!");
                }
                if (hak==0)
                {
                    Console.Write("Hakkınız tükenmiştir!");
                }
            } while (sayi!=uretilenSayi && hak!=0);
            Console.ReadKey();
        }
    }
}
