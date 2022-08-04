using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * String.Format() Metodu:
             * 
             * Ekrana yazılacak ifadelerin belirli bir biçimde ve düzenli bir şekilde
             * yazılması için kullanılmaktadır.
             * Düzenli bir şekilde istenilen formatta yazılan ifadeye ilişkin geriye 
             * string bir değer döndürür.
             */

            string a1 = "11111111111";
            string a2 = "Ahmet Dağsever";
            int a3 = 2500;
            double a4 = 5055055555;

            string b1 = "22222222222";
            string b2 = "Mustafa Türkyılmaz";
            int b3 = 900;
            double b4 = 5555067878;

            Console.WriteLine("Tc Kimlik No | Adı Soyadı           | Maas    | Telefon No |");
            Console.WriteLine(String.Format("{0, -12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |",a1,a2,a3,a4));
            Console.WriteLine(String.Format("{0, -12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |", b1,b2,b3,b4));

            Console.ReadKey();
        }
    }
}
