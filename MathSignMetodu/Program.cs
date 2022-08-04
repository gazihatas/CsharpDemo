using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSignMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Konu: Math.Sign Metodu
             * Açıklama => Parametre olarak verilen sayının
             * işaretini geriye döndürür.
             * Sayı Negatif ie -1, pozitif isee 1, sıfıra eşitse         * 
             * 0 değerini geriye döndürür.
             * 
             * Geriye dönen değer int, double giib bir değişkende
             * saklanabilir.
             */

            int stokAdeti;
            int isaret;

            BASADON:
            Console.Write("Stok adetini giriniz?");
            stokAdeti=Convert.ToInt32(Console.ReadLine());

            isaret = Math.Sign(stokAdeti);
            if (isaret==0 || isaret==-1)
            {
                Console.Clear();
                Console.Write("Lütfen 0'dan büyük pozitif bir değer giriniz!");
                goto BASADON;
            }
            else
            {
                Console.Write("Stok kayıt işlemi başarı ile tamamlanmıştır.");
            }
            Console.ReadKey();
        }
    }
}
