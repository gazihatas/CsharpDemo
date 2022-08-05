using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAFIZA_KARTI_OYUNU
{
    class Program
    {
        static void Main(string[] args)
        {
           //Random sınıfı
            Random rnd = new Random();
            int rastgeleSayi;
           
            //Değişken tanımlamaları
            bool oyun = true;
            int giris1, giris2;
            int run1i, run1j;
            int run2i, run2j;
            int alan = 1;
            int adimSayisi = 0;
            int ciftBul = 0;
            
            //kart dizisi
            string[] kartlar = { "A", "B", "C", "D", "E", "F", "G", "H", "A", "B", "C", "D", "E", "F", "G", "H" };
            //çok boyutlu dizi kartGoruntusu ve kartiçindeki verilerin dizisi oluşturuldu
            string[,] kartGoruntusu = new string[4, 4];
            string[,] kartVeri = new string[4, 4]; ;

            //kartların
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                RastgeleIntAlma:
                    rastgeleSayi = rnd.Next(16);
                    if (kartlar[rastgeleSayi].Equals("0"))
                        goto RastgeleIntAlma;
                    kartVeri[i, j] = kartlar[rastgeleSayi];
                    kartlar[rastgeleSayi] = "0";
                    kartGoruntusu[i, j] = (alan++) + "";
                }
            }

            Stopwatch watch = Stopwatch.StartNew();
            
            while (oyun)
            {
                //Kartlar doğru eşleşti. Oyun sonu
                if (ciftBul == 8)
                {
                    watch.Stop();
                    Console.WriteLine("Oyun bitti");
                    Console.WriteLine("Toplam adım sayısı : " + adimSayisi);
                    Console.WriteLine("Oyun süresi: {0} dakika",watch.ElapsedMilliseconds * 1.66666667 / 100000);
                    Environment.Exit(0);
                }
                //ekrana çıktı
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i < 2)
                            Console.Write("| " + kartGoruntusu[i, j] + "  | ");
                        else if (i == 2 && j == 0)
                            Console.Write("| " + kartGoruntusu[i, j] + "  | ");
                        else if (!int.TryParse(kartGoruntusu[i, j], out int tmp))
                            Console.Write("| " + kartGoruntusu[i, j] + "  | ");
                        else
                            Console.Write("| " + kartGoruntusu[i, j] + " | ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------");

                //kart girişleri ve kontrolleri
                giris1:
                Console.WriteLine("Lutfen 1. kartı seciniz >> ");
                if (!int.TryParse(Console.ReadLine(), out giris1))
                {
                    Console.WriteLine("Lütfen geçeri bir kart girin");
                    goto giris1;
                }
                if (giris1 <= 0 || giris1 > 16)
                {
                    Console.WriteLine("Lütfen geçeri bir kart girin");
                    goto giris1;
                }
                giris2:
                Console.WriteLine("Lutfen 2. kartı seciniz >> ");
                if (!int.TryParse(Console.ReadLine(), out giris2))
                {
                    Console.WriteLine("Lütfen geçeri bir kart girin");
                    goto giris2;
                }
                if (giris2 <= 0 || giris2 > 16)
                {
                    Console.WriteLine("Lütfen geçeri bir kart girin");
                    goto giris2;
                }

                adimSayisi++;

                if (giris1 % 4 != 0)
                {
                    run1i = giris1 / 4;
                    run1j = giris1 % 4 - 1;
                }
                else
                {
                    run1i = giris1 / 4 - 1;
                    run1j = 3;
                }

                if (giris2 % 4 != 0)
                {
                    run2i = giris2 / 4;
                    run2j = giris2 % 4 - 1;
                }
                else
                {
                    run2i = giris2 / 4 - 1;
                    run2j = 3;
                }

                kartGoruntusu[run1i, run1j] = kartVeri[run1i, run1j];
                kartGoruntusu[run2i, run2j] = kartVeri[run2i, run2j];
               
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i < 2)
                            Console.Write("| " + kartGoruntusu[i, j] + "  | ");
                        else if (i == 2 && j == 0)
                            Console.Write("| " + kartGoruntusu[i, j] + "  | ");
                        else if (!int.TryParse(kartGoruntusu[i, j], out int tmp))
                            Console.Write("| " + kartGoruntusu[i, j] + "  | ");
                        else
                            Console.Write("| " + kartGoruntusu[i, j] + " | ");

                    }
                    Console.WriteLine();
                }
                if (!kartVeri[run1i, run1j].Equals(kartVeri[run2i, run2j]))
                {
                    kartGoruntusu[run1i, run1j] = giris1 + "";
                    kartGoruntusu[run2i, run2j] = giris2 + "";
                }
                else
                {
                    ciftBul++;
                }
                    
                Console.WriteLine("--------------------------------");

            }

        }
    }
}
