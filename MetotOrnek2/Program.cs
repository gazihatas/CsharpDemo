using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = topla(5, 15);
            Console.Write("Toplama Sonucu:{0}", sonuc);
            Console.ReadKey();
        }

        private static int topla(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2);
        }
    }
}
