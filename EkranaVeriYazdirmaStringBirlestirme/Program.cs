using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkranaVeriYazdirmaStringBirlestirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string tcno = "12345678901";
            string adsoyad = "lion";
            string gorev = "Satın Alma";
            double maas = 15000.00;
            Console.WriteLine("TC KİMLİK NO : " + tcno + " " + "ADI SOYADI : " + adsoyad);
            Console.WriteLine("Görevi:{0} MAAŞI:{1}", tcno, maas);
            Console.ReadKey();

        }
    }
}
