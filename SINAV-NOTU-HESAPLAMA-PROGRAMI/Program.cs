using System;
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
            //değişken tanımlamaları
            double not, yuzde, ortalama, kalanYuzde;


            MENU:
            Console.WriteLine("****SINAV NOTU HESAPLAYAN PROGRAM****");
            Console.WriteLine("Çıkış için 'E' tuşuna basın");
            Console.WriteLine("Not Hesaplamak için 'H' tuşuna basın");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim=='E' || secim=='e')
            {
                Console.WriteLine("Programdan Çıkılıyor");
                Environment.Exit(0);
            }
            else if (secim=='H' || secim=='h')
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
                int i = 1;
                int sayac = 1;
                do
                {
                    NOT:
                    Console.WriteLine("Lütfen {0}. Notunuzu giriniz", i);
                    if (!double.TryParse(Console.ReadLine(), out not))
                    {
                        Console.WriteLine("lütfen sayı değerinde {0}. notunuzu giriniz!", i);
                        goto NOT;
                    }
                    if (not < 0 || not > 100)
                    {
                        Console.WriteLine("0 dan kücük ve 100 den büyük olamaz");
                        goto NOT;
                    }

                    YUZDE:
                    Console.WriteLine("Notunuzun yüzdesini giriniz :");
                    if (!double.TryParse(Console.ReadLine(), out yuzde))
                    {
                        Console.WriteLine("lütfen sayı değerinde {0}. notunuzun yuzde değerini giriniz!", i);
                        goto YUZDE;
                    }
                    

                    if (yuzde < 0 || yuzde > 100)
                    {
                        kalanYuzde = (not * yuzde) / 100 - not;
                        Console.WriteLine("0 dan kücük ve 100 den büyük olamaz kalan yüzde hakkınız: " + kalanYuzde );
                        goto YUZDE;
                    }
                    if (sayac == Convert.ToInt32(notAdeti) - 1)
                    {
                        Console.WriteLine("Toplam yüzde 100'e tamamlayamaz.");
                    }
                   
                    i++;
                } while (i < Convert.ToInt32(notAdeti));
                
                ortalama = (not * Convert.ToInt32(notAdeti) ) + (yuzde * Convert.ToInt32(notAdeti) ) / 100;

                if (ortalama >= 90 && ortalama <= 100)
                {
                   Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz AA Durumunuz GEÇTİ", dersAdi,ortalama);
                }
                else if (ortalama >= 80 && ortalama < 90)
                {
                    Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz BA Durumunuz GEÇTİ", dersAdi, ortalama);
                }
                else if (ortalama >= 70 && ortalama < 80)
                {
                    Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz bb Durumunuz GEÇTİ", dersAdi, ortalama);
                }
                else if (ortalama >= 60 && ortalama < 70)
                {
                    Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz CB Durumunuz GEÇTİ", dersAdi, ortalama);
                }
                else if (ortalama >= 50 && ortalama < 60)
                {
                    Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz CC Durumunuz GEÇTİ", dersAdi, ortalama);
                }
                else if (ortalama >= 40 && ortalama < 50)
                {
                    Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz DC Durumunuz KALDI", dersAdi, ortalama);
                }
                else if (ortalama >= 30 && ortalama < 40)
                {

                    Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz DD Durumunuz KALDI", dersAdi, ortalama);
                }
                else if (ortalama >=0 && ortalama <30)
                {
                    Console.WriteLine("{0} dersi not ortalamanız {1} Harf notunuz DD Durumunuz KALDI", dersAdi, ortalama);
                }
                else
                {
                    Console.WriteLine("Toplam yüzde 100'e tamamlayamaz!");
                    goto MENU;
                }


            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                goto MENU;
            }
            
            DEVAMSECIM:
            Console.Write("Yeniden işlem yapmak ister misiniz? (EVET:E HAYIR:H)");
            char devamSec = Convert.ToChar(Console.ReadLine());
            if (devamSec == 'E' || devamSec == 'e')
            {
                Console.Clear();
                goto MENU;
            }
            else if (devamSec == 'H' || devamSec == 'h')
            {
                Console.Write("İyi günler.");
                //Console.ReadKey();
            }
            else
            {
                Console.Write("Yanlış seçim yaptınız. Tekrar deneyiniz!");
                goto DEVAMSECIM;
            }



        }
    }
}
