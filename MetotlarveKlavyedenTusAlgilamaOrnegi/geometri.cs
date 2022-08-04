using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarveKlavyedenTusAlgilamaOrnegi
{
    internal class geometri
    {

        public static double kupHacimHesaplamaMetodu(double kupunKenariMetot)
        {
            kupunKenariMetot = Math.Pow(kupunKenariMetot, 3);
            return (kupunKenariMetot);
        }

        public static double koniHacmiHesaplamaMetodu(double koniYariCapMetot, double koniYukseklikMetot)
        {
            const double pi = 3.14;
            double koniHacmiMetot = (pi * Math.Pow(koniYariCapMetot, 2) * koniYukseklikMetot) / 3;
            return (koniHacmiMetot);
        }

        public static double silidirHacmiHesaplamaMetodu(double silindirYariCapMetot, double silindirYukseklikMetot)
        {
            const double pi = 3.14;
            double silindirHacmiMetot = (pi * Math.Pow(silindirYariCapMetot, 2) * silindirYukseklikMetot);
            return (silindirHacmiMetot);
        }

        internal static double silindirHacmiHesaplamaMetodu(double silindirYariCap, double silindirYukseklik)
        {
            throw new NotImplementedException();
        }
    }
}
