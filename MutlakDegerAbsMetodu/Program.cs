using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutlakDegerAbsMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Math.Abs() => Bir sayının mutlak değerini alıp geriye herhangi bir değişken
             * için değer gönderebiliriz.
             * 
             * 
             */

            Console.Write("Bir sayı giriniz?");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int mutlakDeger = Math.Abs(sayi);
            Console.Write("|{0}|:{1}", sayi, mutlakDeger);
            Console.ReadKey();
        }
    }
}
