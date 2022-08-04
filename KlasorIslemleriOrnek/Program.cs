using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorIslemleriOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            Console.Write("Öğrenci Numarasını Giriniz:");
            string ogrenciNo = Console.ReadLine();

            Console.Write("Kayıt Olunacak Sınıf Giriniz:");
            string sinif = Console.ReadLine();

            string klasorYolu = @"c:\okul\" + sinif;
            if (System.IO.Directory.Exists(klasorYolu)==true)
            {
                string ogrenciKlasorHedefYolu = @"c:\okul\" + sinif + "\\" + ogrenciNo;
                System.IO.Directory.CreateDirectory(ogrenciKlasorHedefYolu);
                Console.Write("{0} numaralı öğrenci için klasör oluşturuldu.", ogrenciNo);
            }
            else
            {
                Console.Write("Okulda böyle bir sınıf yoktur! Tekrar deneyiniz!");
                goto BASADON;
            }
            Console.ReadKey();
        }
    }
}
