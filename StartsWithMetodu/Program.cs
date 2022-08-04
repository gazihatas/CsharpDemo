using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartsWithMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * StartsWith() => Bir Metinsel ifadenin paremetre olarak girilen yine bir string
             * ifade ile başlayıp başlamadığını kontrol ederiz.
             * 
             */

            string tcNo;
            Console.Write("TC Kimlik Numaranızı Giriniz?");
            tcNo = Console.ReadLine();
            if(tcNo.StartsWith("0")==true)
            {
                Console.Write("TC Kimlik 0 ile başlayamaz");
            }
            else
            {
                Console.Write("TC Kimlik 0 ile başlamıyor");
            }
            Console.ReadKey();
        }
    }
}
