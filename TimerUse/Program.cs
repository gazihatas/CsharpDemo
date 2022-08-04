using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;//System.Timers Kütüphanesinin Eklenmesi
namespace TimerUse
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer zamanlayici = new Timer();//Timer sınıfının bütün özelliklerini taşıyan zamanlayıcı nesnesi
            //interval =  aralık demektir.
            zamanlayici.Interval = 2000;//Timer hangi zaman aralıklarında çalışacak bunu belirledik (2 Saniyede 1 Kez)

            //Interval ile belirnenen süre her geçtiğinde zamanlanmisGorev isimli oluşturacağımız olay tetiklenecek
            zamanlayici.Elapsed += zamanlanmisGorev;

            zamanlayici.Start();

            Console.ReadKey();
        }

        private static void zamanlanmisGorev(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Write("Ömür hazinesinden 5 saniye daha azaldı");
        }
    }
}
