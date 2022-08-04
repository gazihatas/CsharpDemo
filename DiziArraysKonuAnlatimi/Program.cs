using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziArraysKonuAnlatimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dizi (Arrays) Nedir?
             * Dizi, hafızada aynı isim altında toplayabildiğimi<, aynı türden oluşan
             * değişkenler kümesidir.Dizi kaç elemanlı tanımlanırsa, o kadar sayıda değişken
             * içeren bir küme yapısı oluşturmuş oluruz.
             * 
             * type[] => Dizi değişken türü
             * arrayName => Dizi adı
             * new => Standart ifade
             * type => Değişken Türü
             * []; => Dizi Boyutu
             * 
             * 
             * 
             * ÖRNEK: 
             * int[] array1 = new int[5];
             * 
             * Tek Boyutlu Diziler
             * Diziler tek boyutlu, çok boyutlu ve düzensiz olmak üzere üç grupta incelenir.
             * #=>TEK BOYUTLU
             * #=>ÇOK BOYUTLU
             * #=>DÜZENSİZ
             * 
             * TEK BOYUTLU DİZİ ÖRNEĞİ
             * ORNEK 1:
             * int array2 = new int[5] {10,15,25,30,50}
             * ORNEK 2:
             * string[] gunler = new string[7];
             * gunler[0] = "Pazatesi";
             * gunler[1] = "Salı";
             * gunler[2] = "Çarşamba";
             * gunler[3] = "Perşembe";
             * gunler[4] = "Cuma";
             * gunler[5] = "Cumartesi";
             * gunler[6] = "Pazar";
             * 
             */

            int[] array1 = new int[5];
            /*
            string[] gunler = new string[7];
            gunler[0] = "Pazatesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";
            */

            //ORNEK
            string[] gunler1 = new string[7] {"1","2","3","4","5","6","7"};
            string[] gunler2 = new string[7] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi","Pazar" };
            Console.WriteLine("Haftanın {0}. günü {1} günüdür.", gunler1[4], gunler2[4]);


            //çok boyutlu diziler
            int[,] notlar = new int[3, 2] { { 50, 60 }, { 70, 80 }, { 40, 30 } };
            Console.WriteLine("1. Satır 1.Eleman:{0}",notlar[0,0]);
            Console.WriteLine("2. Satır 2.Eleman:{0}",notlar[1,1]);
            Console.WriteLine("3. Satır 1.Eleman:{0}",notlar[2,0]);
            Console.ReadKey();


            /*
             * Dizilerle Foreach Kullanımı:
             * Dizi elemanlarının pratik olarak yazdırılması için kullanılabilir.
             * For dögüsü gibi yaygın olarak kullanılmaktadır.
             * 
             */

            string[] sehirler = new string[5] { "Konya", "Ankara", "İstanbul", "Kayseri", "Bursa" };
            foreach (var sehir in sehirler)
            {
                Console.WriteLine("{0}",sehir);   
            }
            Console.ReadKey();

            int[] ogrenciler = new int[6] { 100,101,102,103,104,105};
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine("{0}", ogrenci);
            }
            Console.ReadKey();

            /*
             * Clear Metodu (Diziyi Temizleme):
             * Beliritlen aralıktaki dizi elemanlarını siler.
             * Dizinin türü int ise silinen eleman değerleri yerine 0
             * string ise boş karakter (" ") yazar.
             * 
             */
            int[] ogrenciler2 = new int[6] { 100, 101, 102, 103, 104, 105 };
            Array.Clear(ogrenciler2, 2, 3);
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine("{0}", ogrenci);
            }
            Console.ReadKey();

            //ArrayList.Sort() ve Length Yöntemi:
            /*
             * Sort => Diziyi alfabetil olarak sıralar. 
             * Length => Dizinin boyutunu verir.
             * 
             */
            string[] sehirler2 = new string[] { "Konya", "İstanbul", "Ankara", "İzmir", "Muğla", "Bingöl" };
            Array.Sort(sehirler2);
            foreach (var sehir in sehirler2)
            {
                Console.WriteLine("{0}",sehir);
            }
            Console.Write("Dizideki Eleman Sayısı:{0}", sehirler.Length);
            Console.ReadKey();

            //Diziyi Tersine Çevirme (Array.Reverse())

            int[] sayilar3 = new int[5] { 1, 2, 3, 4, 5 };
            Array.Reverse(sayilar3);
            foreach (var sayi in sayilar3)
            {
                Console.WriteLine("{0}", sayi);
            }
            Console.ReadKey();


            //Dizide Eleman Arama - IndexOf() ve LastIndexOf()
            //IndexOf => ara demek, 1 den başlayarak arar.ü
            string[] personelListesi = new string[5] { "Yıldız Kartel", "Mehmet Serten", "Burak Yavaş", "Cemil Seyran", "Dündar Ay" };
            Console.Write(Array.IndexOf(personelListesi, "Cemil Seyran"));
            Console.ReadKey();

            //LastIndexOf => Sondan başa doğru ara demek. Sondan başlayarak arar. 
            string[] personelListesi2 = new string[5] { "Yıldız Kartel", "Mehmet Serten", "Burak Yavaş", "Cemil Seyran", "Dündar Ay" };
            Console.Write(Array.LastIndexOf(personelListesi2, "Cemil Seyran"));
            Console.ReadKey();
            //dizinin kaçıncı elemanı olduğunu ekrana yazdırır.

        }
    }
}
