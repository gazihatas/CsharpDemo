using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosyayaVeriYazmaIslemi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. YÖNTEM: DİZİ ELEMANLARINI SATIR SATIR TEXT DOSYASINA YAZDIRMA
            string[] satirlar = { "Öğrenci No:123","Adı:Mehmet","Soyadı:Yılmaz"};
            System.IO.File.WriteAllLines(@"c:\DENEME\DENEME1.txt",satirlar);

            //2. YÖNTEM: STRING BİR DEĞİŞKENİ TEXT DOSYASINA YAZDIRMA
            string ozgecmis = "984 yılında Ankara ilinin Gölbaşı İlçesinde dünyaya gelmiştir.";
            System.IO.File.WriteAllText(@"c:\DENEME\DENEME2.txt", ozgecmis);

            //3. YÖNTEM: BİR DİZİDEKİ YALNIZCA İSTENİLEN ELEMANLARI TEXT DOSYASINA YAZDIRMA
            string[] personeller = { "PERSONEL:MEHMET AYDIN", "PERSONEL:MUSTAFA KAYA", "MÜDÜR:EBRU AKTEN", "MÜDÜR:SÜLEYMAN KARTAL" };
            using(System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\DENEME\DENEME3.txt"))
            {
                foreach (string  personel in personeller)
                {
                    if (personel.Contains("MÜDÜR"))
                    {
                        dosya.WriteLine(personel);
                    }
                }
            }

            //4. YÖNTEM: VAROLAN BİR TEXT DOSYASINA METİN EKLEME
            using (System.IO.StreamWriter dosya1 = new System.IO.StreamWriter(@"c:\DENEME\DENEME4.txt", true))
            dosya1.WriteLine("EKLENEN SATIRLAR");

        }
    }
}
