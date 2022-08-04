using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlavyedenTusOkuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir tuşa basınız!");
            string tus = Convert.ToString(Console.ReadLine());

            Console.Write("Klavyeden Basılan Tuş: {0}", tus);
            Console.ReadKey();
        }
    }
}
