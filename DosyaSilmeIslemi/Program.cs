using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyaSilmeIslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = @"c:\sil\deneme.txt";
            if (System.IO.File.Exists(dosyaYolu))
            {
                System.IO.File.Delete(dosyaYolu);
                Console.Write("Dosya yolu");
            }
            else
            {
                Console.Write("Silinmek istenilen dosya mevcut değil");
            }
            Console.ReadKey();
        }
    }
}
