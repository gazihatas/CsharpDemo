using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetotlarlaCalismak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * String.IsNullOrEmpty =>String türündeki değişkene değer atanıp atanmadığını kontrol ederiz
             * 
             */
            string ogrno, ad, soyad;
            Console.Write("Öğrenci numaranızı giriniz?");
            ogrno = Console.ReadLine();
            Console.Write("Adınızı Giriniz?");
            ad  = Console.ReadLine();
            Console.Write("Soyadınızı giriniz?");
            soyad = Console.ReadLine();
            if (String.IsNullOrEmpty(ogrno)==true)
            {
                Console.WriteLine("Öğrenci numaranızı boş geçemezsiniz!");
            }
            if (String.IsNullOrEmpty(ad)==true)
            {
                Console.WriteLine("Adınızı boş geçemezsiniz!");
            }
            if (String.IsNullOrEmpty(soyad)==true)
            {
                Console.WriteLine("Soyadınızı Boş geçemezsiniz!");
            }
            if (String.IsNullOrEmpty(ogrno) == false && String.IsNullOrEmpty(ad) == false && String.IsNullOrEmpty(soyad) == false)
            {
                Console.Write("Kayıt işlemi başarı ile tamamlanmıştır.");
            }
            Console.ReadKey();
        }
    }
}
