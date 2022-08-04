using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Belirli komutların sürekli olarak çalışmasını sağşlar.
             * -iken anlamına gelmektedir.
             * 
             */

            /*
            int x = 1;
            while (x<=5)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.ReadKey();
        
            */

            Console.Write("1.Sayıyı Giriniz?");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            while (sayi1<=sayi2)
            {
                Console.WriteLine(sayi1);
                sayi1++;
            }
            Console.ReadKey();

            //1 ile 100 arasındaki sayıların 3 ün katı olanlarının ekrana basılması
            int x = 1;
            while (x <= 100)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }
            Console.ReadKey();

        }
    }
}
