using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciKaydiOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adı belirleyiniz?");
            string kullaniciAdi = Console.ReadLine();
            SIFREBELIRLE:
            Console.Write("Şifrenizi belirleyiniz?");
            string sifre1 = Console.ReadLine();
            Console.Write("Belirlediğiniz şifreyi tekrar giriniz?");
            string sifre2 = Console.ReadLine();
            int kontrol = String.Compare(sifre1, sifre2,false);
            if (kontrol==0)
            {
                string sifre = sifre1;
                Console.Write("Kayıt işlemi başarı ile tamamlanmıştır. Kullanıcı Adı:{ 0} Şifre:{1}", kullaniciAdi, sifre);
      
            }
            else
            {
                Console.Write("Girilen sifreler uyuşmuyor");
                goto SIFREBELIRLE;
            }
            Console.ReadKey();
        }
    }
}
