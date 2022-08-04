using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSinifiMaxveMinMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet, sayi, enBuyuk, enKucuk;
            Console.Write("Kaç adet sayı gireceksiniz?");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.Write("1. Sayıyı Giriniz?");
            sayi = Convert.ToInt32(Console.ReadLine());

            enBuyuk = sayi;
            enKucuk = sayi;
            for (int i = 2; i <= adet; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz?", i);
                sayi = Convert.ToInt32(Console.ReadLine());
                enBuyuk = Math.Max(enBuyuk, sayi);
                enKucuk = Math.Min(enKucuk, sayi);
            }
            Console.Write("En Büyük Sayı:{0} En Küçük Sayı:{1}", enBuyuk, enKucuk);
            Console.ReadKey();
        }
    }
}
