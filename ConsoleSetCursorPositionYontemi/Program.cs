using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSetCursorPositionYontemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARA Konu: Console.SetCursorPosition Yöntemi (Int32, Int 32)
            // Console.SetCursorPosition(5,3);
            // Sütun değeri 0-...(6.sutun) - Satır değeri 0-....(4. sutun)

            Console.SetCursorPosition(5, 3);
            Console.Write("Türkiye");
            Console.ReadKey();
        }
    }
}
