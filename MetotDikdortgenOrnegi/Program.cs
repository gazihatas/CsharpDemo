using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotDikdortgenOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kısa kenar uzuluğunu giriniz?");
            double kisaKenar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Uzun Kenar Uzunluğunu Giriniz?");
            double uzunKenar = Convert.ToDouble(Console.ReadLine());

            double dikdortgenAlan = alanCevreHesapla.alanHesapla(kisaKenar, uzunKenar);
            double dikdortgenCevre = alanCevreHesapla.cevreHesapla(kisaKenar, uzunKenar);
            Console.Write("Dikdörtgenin Alanı:{0} Dikdörtgenin Çevresi:{1}",dikdortgenAlan,dikdortgenCevre);
            Console.ReadKey();
        }

        class alanCevreHesapla
        {
            public static double alanHesapla(double kisaKenar, double uzunKenar)
            {
                double alan = kisaKenar * uzunKenar;
                return (alan);
            }

            public static double cevreHesapla(double kisaKenar, double uzunKenar)
            {
                double cevre = 2 * (kisaKenar + uzunKenar);
                return (cevre);
            }


        }
    }
}
