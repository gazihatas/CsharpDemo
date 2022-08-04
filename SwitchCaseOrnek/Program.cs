using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            char secim;
            Console.WriteLine("1-Batı Karadeniz Turu");
            Console.WriteLine("2-İç Anadolu Turu");
            Console.WriteLine("3-Akdeniz Turu");
            Console.WriteLine("4-Ege Turu");
            Console.WriteLine("SEçimi, Yapınız [1,2,3,4]?");
            secim = Convert.ToChar(Console.ReadLine());

            switch (secim)
            {
                case '1':
                    Console.WriteLine("Batı Karadeniz Turu");
                    Console.WriteLine("Tarih Aralığı:30:01:2022-01.02.2022");
                    Console.WriteLine("Pazartesi:Karabük Salı:Kastamonu Çarşamba:Sinop Perşembe:Bartın");
                    Console.WriteLine("Fiyat:2 kişi+0-6 Yaş Çoçuk 600₺ (Her yetişkin için +200₺)");
                    break;
                case '2':
                    Console.WriteLine("İç Anadolu Turu");
                    Console.WriteLine("Tarih Aralığı:30:01:2022-01.02.2022");
                    Console.WriteLine("Çarşamba:Ankara Perşembe:Konya Cuma:Eskişehir");
                    Console.WriteLine("Fiyat:2 kişi+0-6 Yaş Çoçuk 450₺ (Her yetişkin için +200₺)");
                    break;
                case '3':
                    Console.WriteLine("Akdeniz Turu");
                    Console.WriteLine("Tarih Aralığı:30:01:2022-01.02.2022");
                    Console.WriteLine("Pazar,Pazartesi:Antalya, Salı,Çarşamba:Mersin Perşembe:Hatay");
                    Console.WriteLine("Fiyat:2 kişi+0-6 Yaş Çoçuk 900₺ (Her yetişkin için +225₺)");
                    break;
                case '4':
                    Console.WriteLine("Ege Turu");
                    Console.WriteLine("Tarih Aralığı:30:01:2022-01.02.2022");
                    Console.WriteLine("Pazartesi:Muğla Salı:İzmir Çarşamba:Aydın");
                    Console.WriteLine("Fiyat:2 kişi+0-6 Yaş Çoçuk 1100₺ (Her yetişkin için +275₺)");
                    break;
                default:
                    Console.WriteLine("1,2,3,4 dışında hatalı seçim yaptınız");
                    break;
            }
            Console.ReadKey();
        }
    }
}
