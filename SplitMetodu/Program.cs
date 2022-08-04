using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Split() Metodu => Kesme anklamına gelmektedir.
             * Bir string ifadeyi istediğimiz bir karakterden itibaren parçalara bölmek
             * için kulladığımız metotdur.
             * 
             */

            string adsoyad = "Mustafa Yılmaz";
            string[] dizi = adsoyad.Split(' ');//metni boşluklardan itibaren parçakanacak
            Console.WriteLine(dizi[0]);
            Console.WriteLine(dizi[1]);
            Console.ReadKey();

             
        }
    }
}
