using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorKopyalamaIslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kaynakKlasor = @"c:\ÖNEMLİ DOSYALAR";
            string hedefKlasor = @"c:\YEDEK";
            string hedefDosyaYolu;

            if (System.IO.Directory.Exists(kaynakKlasor))
            {
                //kanakKlasor yolundaki tüm dosyaları bir diziye aktardık.
                string[] dosyalar = System.IO.Directory.GetFiles(kaynakKlasor);

                string dosyaAdi;
                foreach (var dosya in dosyalar)
                {
                    dosyaAdi = System.IO.Path.GetFileName(dosya);
                    hedefDosyaYolu = System.IO.Path.Combine(hedefKlasor, dosyaAdi);
                    System.IO.File.Copy(dosya, hedefDosyaYolu, true);
                }
            }
            else
            {
                Console.Write("Kaynak dosya bulunamadı.");
            }
            Console.ReadKey();
        }
    }
}
