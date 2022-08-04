using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazırStringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * METİNSEL (STRİNG) METOTLAR
             */

            /*
             * String.Compare() Metodu:
             * Parametre olarak verilen iki string ifadeyi karşılaştırır ve geriye int türünde
             * bir veri döndürür. Eğer dönüş değeri sıfır (0) ise iki metin birbirine eşittir.
             * Aksi taktirde parametre olarak verilen metinleri ilk harflerinden itibaren tek tek 
             * karşılaştırır ve farklılığın oldupu ilk harflerin alfadeki sıralarına göre -1 veya 1
             * sayı değerini döndürür.
             * 
             * sonuç olarak 0 değeri geriye döndürülüyorsa değişkenlerin değeri birbirine eşittir.
             * 0 değilse eşit değildir.
             */

            int karsilastirma = String.Compare("admin", "admin");
            Console.Write(karsilastirma);
            Console.ReadKey();
            //sonuc 0 dır çünkü eşittir değerler aynıdır


        }
    }
}
