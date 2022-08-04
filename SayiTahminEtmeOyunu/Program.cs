using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminEtmeOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(10, 20);
            Console.WriteLine("Üretilen Sayı : {0}", rastgeleSayi);
            int hak = 3;
            
            //Etiketler = Etiketler programlamada programın akışı esnasında çeşitli yerlere dallanmayı sağlar.
            BASADON:
            Console.WriteLine("Bir tahminde bulununuz?");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (tahmin==rastgeleSayi)
            {
                Console.WriteLine("Tebrikler... Puan:{0}", hak * 10);
            }
            else if (tahmin<rastgeleSayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.Write("Kaybettiniz. Hakkınız kalmadı");
                }
                else
                {
                    Console.Write("Tahmininiz büyütünüz.");
                    goto BASADON;
                }

            }
            else if (tahmin>rastgeleSayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.Write("Kaybettiniz. Hakkınız kalmadı");
                }
                else
                {
                    Console.Write("Tahmininizi küçültünüz.");
                    goto BASADON;
                }
            }
            Console.ReadKey();
        }
    }
}
