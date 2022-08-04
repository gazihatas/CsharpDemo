using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen 6 adet sayının negatif ve pozitif olarak ayrılmasını sağlayan program

            int sayi = 0;
            for (int sayac = 1; sayac <=6; sayac++)
            {
                Console.Write("{0}. sayıyı giriniz?",sayac);
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi>0)
                {
                    Console.WriteLine("Pozitif");
                }
                else if (sayi<0)
                {
                    Console.WriteLine("Negatif");
                }
                else
                {
                    Console.WriteLine("Sıfır");
                }
            }
            Console.ReadKey();
        }
    }
}
