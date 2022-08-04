using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolmeUygulamasiDivRemMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bolunen, bolen, kalan, bolum;

            Console.WriteLine("Bölünen sayıyı giriniz");
            bolunen = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bölen sayıyı giriniz?");
            bolen = Convert.ToInt32(Console.ReadLine());

            bolum = Math.DivRem(bolunen, bolen, out kalan);
            Console.Write("Bölüm:{0}", bolum);
            Console.Write("Kalan:{0}", kalan);
            Console.ReadKey();

        }
    }
}
