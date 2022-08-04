using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * String.Concat() => PARANTEZ İÇERİSİNDE YAZILAN DEĞİŞKENLERİ STRİNG
             * VERİ TÜRÜNDE BİRLEŞTİRİR.
             * İNT VE DOUBLE VERİT TÜRLERİNİN BİRLEŞTİRİP STRİNG VERİ TÜRÜNDE SAKLANIR.
             */

            string tcNo = "12345678901";
            string ad = "Ali";
            string soyad = "Kaya";
            double maas = 2500;
            int cocukSayisi = 5;

            string birlestirilenVeri = String.Concat(tcNo + " " + ad + " " + soyad + " " + maas + " " + cocukSayisi);
        }

    }
}
