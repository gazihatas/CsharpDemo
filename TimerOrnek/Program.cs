using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerOrnek
{
    class Program
    {
        private static int x = 10;
        private static Timer sayac = new Timer();

        static void Main(string[] args)
        {
            sayac.Interval = 1000;
            sayac.Elapsed += geriSayim;
            sayac.Start();
            Console.ReadKey();
        }

        private static void geriSayim(Object source, System.Timers.ElapsedEventArgs e)
        {
            x--;
            Console.Clear();
            Console.WriteLine(x);
            if (x==0)
            {
                Console.Write("Süre Bitti.");
                sayac.Stop();
            }
            
        }
    }
}
