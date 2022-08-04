using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //for ile 5 adet sayının yazılması
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            //girilen sayıların ortalamasını hesaplayan program

            int sayi;
            int toplam = 0;
            int ortalama;
            for (int sayac = 1; sayac <=5; sayac++)
            {
                Console.Write("{0}. sayıyı giriniz?");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }
            ortalama = toplam / 5;

            Console.Write("Ortalama:{0}", ortalama);
            Console.ReadKey();

            //5 ile 250 arasındaki 5'in katı olan sayıların ekrana yazdırılması
            for (int i = 5; i < 250; i=i+5)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
