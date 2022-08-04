using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasorOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KLASÖR OLUŞTURMA İŞLEMİ
            string klasorAdi = @"c:\programlama";
            System.IO.Directory.CreateDirectory(klasorAdi);
        }
    }
}
