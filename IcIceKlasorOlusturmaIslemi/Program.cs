using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcIceKlasorOlusturmaIslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İÇ İÇE KLASÖR OLUŞTURMA İŞLEMİ

            string klasorAdi = @"c:\programlama";
            System.IO.Directory.CreateDirectory(klasorAdi);
            
            string altKlasorAdi = System.IO.Path.Combine(klasorAdi, "c#");
            System.IO.Directory.CreateDirectory(altKlasorAdi);
        }
    }
}
