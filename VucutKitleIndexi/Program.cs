using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucutKitleIndexi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vücut Kitle Endeksi
            double kilo, boy, vki;
            Console.Write("Kilonuzu giriniz?");
            kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Boy uzunluğunu giriniz (metre)");
            boy = Convert.ToDouble(Console.ReadLine());

            vki = kilo / (boy * boy);

            if(vki<=18.4)
            {
                Console.Write("Vücut Kitle Endeksi:{0} Kategori:Zayıf", vki);
            } else if(vki<=24.9)
            {
                Console.Write("Vücut Kitle Endeksi:{0} Kategori:Normal", vki);
            }
            else if (vki<=29.9)
            {
                Console.Write("Vücut Kitle Endeksi:{0} Kategori:Fazla Kilolu", vki);
            }
            else if(vki <= 34.9)
            {
                Console.Write("Vücut Kitle Endeksi:{0} Kategori:Obez 1. Sınıf", vki);
            }
            else if(vki <=44.9)
            {
                Console.Write("Vücut Kitle Endeksi:{0} Kategori:Obez 2. Sınıf", vki);
            }
            else if(vki > 44.9)
            {
                Console.Write("Vücut Kitle Endeksi:{0} Kategori:Aşırı Obez", vki);
            }
            Console.ReadKey();
        }
    }
}
