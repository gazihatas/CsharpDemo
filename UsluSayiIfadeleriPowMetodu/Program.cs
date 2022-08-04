using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsluSayiIfadeleriPowMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //üslü sayı ifadelerinde kullanılan metotdur.
            //Pow metodu geriye double değer dondurur.

            int taban, us;
            double sonuc;
            
            Console.Write("Sayının taban değerini giriniz?");
            taban = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Sayının üs değerini giriniz?");
            us = Convert.ToInt32(Console.ReadLine());

            sonuc = Math.Pow(taban, us);

            
            Console.Write("{0} üzeri {1}:{2}",taban,us,sonuc);
            Console.ReadKey();
        }
    }
}
