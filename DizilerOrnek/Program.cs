using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personelListesi = new string[5] { "Mehmet Ertan", "Mustafa Ay", "Aynur Kaynak", "Meltem Ay", "Cumhur Türkmen" };
            Array.Sort(personelListesi);
            for (int i = 0; i <=4; i++)
            {
                Console.Write("{0}",personelListesi[i]);
            }
            Console.ReadKey();

            string[] gunler1 = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            string[] gunler2 = new string[7] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = 0; i <=6; i++)
            {
                Console.WriteLine(gunler1[i] + " " + gunler2[i]);
            }
            Console.ReadKey();

            int[] ogrenciler = new int[6] { 100, 101, 102, 103, 104, 105 };
            int[,] notlar = new int[5, 3] { {50,60,70 },{ 50, 50, 50 },{40,40,40},{80,70,90}, {85,85,85} };
            int j = 0;
            for (int i = 0; i <=4; i++)
            {
                double ortalama = (notlar[i, j] + notlar[i, j + 1] + notlar[i, j + 2]) / 3;
                Console.WriteLine("Öğrenci No:{0} Ortalama:{1}",ogrenciler[i], ortalama);
            }
            Console.ReadKey();

            //çift sayıların ekrana yazıdırlması
            int[] ciftSayilar = new int[13];
            int sayi = 0;

            for (int i = 0; i < 12; i++)
            {
                ciftSayilar[i] = sayi;
                Console.WriteLine("{0}", ciftSayilar[i]);
                sayi = sayi + 2;
            }
            Console.ReadKey();
        }
    }
}
