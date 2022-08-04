using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimciTuslarIleKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Yardımcı Tuşların algılanmasını sağlamak 
             */

            //Bir tuşa basıldığı zaman bu bilgileri tutmak kullanılan bir yöntem
            ConsoleKeyInfo tusBilgisi;

            //programın break olmasını sağlar.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Bir tuşa veya CTRL, ALT, SHIFT + BİR TUŞA BASINIZ?");
            Console.Write("ÇIKMAK İÇİN ESC TUŞUNA BASINIZ?");

            do
            {
                tusBilgisi = Console.ReadKey();
                Console.ReadKey();
                //Modifiers => Yardımcı tuşlar demektir.
                if ((tusBilgisi.Modifiers & ConsoleModifiers.Alt)!=0)//Alt tuşuna basılmışsa if bloğu çalışacak
                {
                    if (tusBilgisi.Key.ToString() == "8") 
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Console.WriteLine("ALT+{0}", tusBilgisi.Key.ToString());
                }
                else if ((tusBilgisi.Modifiers & ConsoleModifiers.Control)!=0)
                {
                    if (tusBilgisi.Key.ToString() == "R")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine("ALT+{0}", tusBilgisi.Key.ToString());
                }
                else if ((tusBilgisi.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    
                    Console.WriteLine("SHIFT+{0}", tusBilgisi.Key.ToString());
                }
                else
                {
                    Console.WriteLine(tusBilgisi.Key.ToString());
                }
            } while (tusBilgisi.Key!=ConsoleKey.Escape);//Konsol tuşlarından escape tuşuna basılmadığı süree döngü devam edecek.

            
        }
    }
}
