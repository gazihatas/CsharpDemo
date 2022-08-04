using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareKokAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * KONU: KARAKÖK ALMA
             * AÇIKLAMA: Parametre olarak verilen double türündeki
             * sayıının karekök değerini yine double türünde geriye
             * döndürür.
             */

            Console.Write("1. Kenar Uzunluğunu Giriniz?");
            double kenar1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("2. Kenar Uzunluğunu Giriniz?");
            double kenar2 = Convert.ToDouble(Console.ReadLine());

            double kenarlarinKareleriToplami = Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2);
            double hipotenus = Math.Sqrt(kenarlarinKareleriToplami);
            Console.Write("Hipotenüs Uzunluğu:{0}", hipotenus);
            Console.ReadKey();
        }
    }
}
