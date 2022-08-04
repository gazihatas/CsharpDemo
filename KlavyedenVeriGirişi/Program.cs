using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlavyedenVeriGirişi
{
    class Program
    {
        static void Main(string[] args)
        {
            double boy, kilo, bki;

            Console.WriteLine("Boyunuzu metre cinsinden giriniz?");
            boy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kilonuzu kg cinsinden giriniz?");
            kilo = Convert.ToDouble(Console.ReadLine());

            bki = kilo / (boy * boy);
            Console.Write("Beden Kitle İndeksiniz: {0}", bki);
            Console.ReadKey();
            
        }
    }
}
