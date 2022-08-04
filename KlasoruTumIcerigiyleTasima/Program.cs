using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasoruTumIcerigiyleTasima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kaynakDosya = @"c:\c#";
            string hedefDosya = @"c:\DERSLER\C#";

            System.IO.Directory.Move(kaynakDosya, hedefDosya);
        }
    }
}  

