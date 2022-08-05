﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAV_NOTU_HESAPLAMA_PROGRAMI
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
         * 
         * 
        * Kullanıcıya seçenek sunulur.
        • Çıkış için “E”
        • Not hesaplamak için “H”
        Seçimin “H” olması durumunda:
        Kullanıcıdan string tpinde dersin adı istenir.
        Kullanıcıdan kaç adet not girileceği istenir.
        Kullanıcının girdiği not adedi kadar kullanıcıdan notu ve ardından yüzdesi için sayı istenir.
        Kullanıcının girdiği not ve yüzdeleri hesaplanarak sonuç elde edilir.
        Sonuca göre harf notu hesaplanır.
        Harf notuna göre geçti/kaldı durumu hesaplanır.
        Ekrana dersin adı, not ortalaması, harf notu ve geçti/kaldı durumu verilir.
        Kullanıcı “E” seçene kadar seçenek sunulmaya ve not hesaplamaya devam edilir.
        Kullanıcı “E” sçerse program sonlandırılır.
        ! Kullanıcı “E” veya “H” dışında bir seçenekte bulunursa uyarılır.
        ! İlk seçim için büyük/küçük harf fark etmez, kullanıcı E,e,H,h girebilir.
        ! Kullanıcı not veya yüzdeler için 100’den fazla veya negatif bir sayı giremez.
        ! Kullanıcının girdiği yüzdeler toplamı tam olarak 100’e eşit olmalıdır. Eksik veya fazla olamaz.
        ! Kullanıcı not hesaplama adımlarında string veya char değerinde bir giriş yapamaz.
        */

            MENU:
            Console.WriteLine("****SINAV NOTU HESAPLAYAN PROGRAM****");
            Console.WriteLine("Çıkış için 'E' tuşuna basın");
            Console.WriteLine("Not Hesaplamak için 'H' tuşuna basın");
            char secim = Convert.ToCharConsole.ReadLine();
            if (secim=="E" && secim=="e")
            {
                Console.WriteLine("Programdan Çıkılıyor");
                Environment.Exit(0);
            }
            else if (secim=="H" && secim=="h")
            {
                DERSSECIM:
                Console.WriteLine("Lütfen dersin adını giriniz?");
                string dersAdi = Console.ReadLine();
                
                NOTADETI:
                Console.WriteLine("Lütfen gireceğiniz not adetini yazınız.");
                string notAdeti = Console.ReadLine();
                int number;
                bool result1 = int.TryParse(notAdeti, out number);
                if (result1 == false)
                {
                    goto NOTADETI;
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                goto MENU;
            }



        }
    }
}
