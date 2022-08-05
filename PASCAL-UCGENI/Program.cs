using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASCAL_UCGENI
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * PASCAL ÜÇGENİ
                Kullanıcıdan üçgenin kaç satır içereceği istenir.
                Seçimin sonucuna göre ekrana pascal üçgeni bastırılır.
             * 
             */

            Console.WriteLine("**** PASCAL UCGENI HESAPLAMA ****");
            Console.WriteLine("Üçgenin kaç satır içereceğini giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
        }
    }
}
