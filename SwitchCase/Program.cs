using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * SWITCH CASE YAPISI 
             * 
             * Bir değişkenin değeri, sabitlerden oluşan bir listede sürekli test edilir.
             * Değişkenin değeri sabitlerden birisi ile eşleştiğinde,
             * bu eşleşme ile ilgili komutlar yorumlanır. Aynı switch içinde iki case sabiti aynı değere sahip olamaz.
             * Default kullanımı zorunlu değildir.
             *Break switch döngüsünden çıkma işlemini gerçekleştirir.
             * 
             */

            double sayi1, sayi2, sonuc;
            char secim;
            
            Console.Write("1. sayıyı giriniz?");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı giriniz?");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("1:Toplama 2:Çıkarma 3:Çarpma 4:Bölme Seçiminizi Yapınız?");
            secim = Convert.ToChar(Console.ReadLine());

            switch (secim)
            {
                case '1':
                    sonuc = sayi1 + sayi2;
                    Console.Write("Toplama Sonucu:{0}", sonuc);
                     break;
                case '2':
                    sonuc = sayi1 - sayi2;
                    Console.Write("Çıkarma Sonucu:{0}", sonuc);
                    break;
                case '3':
                    sonuc = sayi1 * sayi2;
                    Console.Write("Çarpma Sonucu:{0}", sonuc);
                    break;
                case '4':
                    sonuc = sayi1 / sayi2;
                    Console.Write("Bölme Sonucu:{0}", sonuc);
                    break;
                default:
                    Console.Write("Hatalı menü girişi yapıldı. Lutfen 1,2,3 veya 4 seçimi yapınız");
                    break;
            }
            Console.ReadKey();

        }
    }
}
