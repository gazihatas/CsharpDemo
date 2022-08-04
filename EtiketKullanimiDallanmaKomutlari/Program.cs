using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiketKullanimiDallanmaKomutlari
{
    class Program
    {
        static void Main(string[] args)
        {
        //Etitk
        //programın gidilmesi istenilen noktalarına etiketler tanımlanır.
        //Yönlendirilmek istenilen komut satırına yazılan goto ifadesinden sonra
        //gidilmesi istenilen etiket buraya yazılarak dallanma sağlanır

        //3 adet yazılnı notunun ortalamasını hesaplayan kullanıcı isterse bu işlemi tekrar yapan program.

            BASADON:
            Console.Clear();
            Console.Write("1. Yazılı  Notunu Giriniz?");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Yazılı  Notunu Giriniz?");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Yazılı  Notunu Giriniz?");
            int y3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (y1 + y2 + y3) / 3;

            Console.WriteLine("ORTALAMA:{0}", ortalama);

            SECIMYAP:
            Console.Write("Yeniden işlem yapmak istermisiniz? (e veya h)");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim=='E' || secim=='e')
            {
                goto BASADON;
            }
            else if (secim=='H' || secim=='h')
            {
                Console.Write("İyi Günler...");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış seçim yaptınız. Tekrar deneyiniz...");
                goto SECIMYAP;
            }
            Console.ReadLine();

        }
    }
}
