using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotStaticKavramiOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * static keyword u kullanılmazsa eğer 
             * metodun bulunduğu sınıftan bir nesne üretilip kullanılmalıdır.
             */
            metotlar metot1 = new metotlar();
            int sonuc = metot1.topla(5, 8);
            Console.Write(sonuc);
            Console.ReadKey();

            /*
            int sonuc = metotlar.topla(5,8);
            Console.Write(sonuc);
            Console.ReadKey();
            */
        }

        class metotlar
        {
            public int topla(int s1, int s2)
            {
                return (s1 + s2);
            }
        }
    }
}
