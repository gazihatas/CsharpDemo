using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarveKlavyedenTusAlgilamaOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tusBilgisi;

            do
            {
                Console.Clear();
                Console.WriteLine("CTRL+K: Küp Hacmi");
                Console.WriteLine("ALT+O Koni Hacmi");
                Console.WriteLine("SHIFT+A Silindir Hacmi");
                Console.WriteLine("Seçimizi Yapınız!");

                tusBilgisi = Console.ReadKey();

                if ((tusBilgisi.Modifiers & ConsoleModifiers.Control)!=0)
                {
                    if (tusBilgisi.Key.ToString()=="K")
                    {
                        Console.Write("Küp kenar uzunuğunu giirniz?");
                        double kenar = Convert.ToDouble(Console.ReadLine());

                        double sonuc = geometri.kupHacimHesaplamaMetodu(kenar);
                        Console.WriteLine("Küpün Hacmi:{0}", sonuc);  
                    }
                }
                else if ((tusBilgisi.Modifiers & ConsoleModifiers.Alt)!=0)
                {
                    if (tusBilgisi.Key.ToString()=="O")
                    {
                        Console.Write("Koni yarıçap uzunluğunu giriniz?");
                        double koniYariCap = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Koni yükseklik uzunluğunu giriniz");
                        double koniYukseklik = Convert.ToDouble(Console.ReadLine());

                        double sonuc = geometri.koniHacmiHesaplamaMetodu(koniYariCap, koniYukseklik);
                        Console.WriteLine("Koninin Hacmi:{0}", sonuc);

                    }
                }
                else if ((tusBilgisi.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    if (tusBilgisi.Key.ToString() == "A")
                    {
                        Console.Write("Silindir yarıçap uzunluğunu giriniz?");
                        double silindirYariCap = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Silindir yükseklik uzunluğunu giriniz");
                        double silindirYukseklik = Convert.ToDouble(Console.ReadLine());

                        double sonuc = geometri.silidirHacmiHesaplamaMetodu(silindirYariCap, silindirYukseklik);
                        Console.WriteLine("Silindirin Hacmi:{0}", sonuc);

                    }
                }

            } while (Console.ReadKey().Key.ToString()!="Escape");
        }
    }
}
