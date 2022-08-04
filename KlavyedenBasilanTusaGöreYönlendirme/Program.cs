using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlavyedenBasilanTusaGöreYönlendirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            Console.Write("Hangi harf ile başlayan iller listelensin?");
            string tus = Convert.ToString(Console.ReadKey().Key);

            if (tus == "A")
            {
                Console.Write("Ankara, Aydın, Artvin");
            }
            else if (tus =="B")
            {
                Console.Write("Bursa, Balıkesir");
            }
            else if (tus=="Oem4")
            {
                Console.Write("İstanbul, İzmir");
            }
            else
            {
                Console.Write("Bu harf ile başlayan il bulunamadı!");
                goto BASADON;
            }
            Console.ReadKey();
        }
    }
}
