using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest1
{
    class Calculator
    {
        public const double pi = 3.14;

        public static double Osszead(double egyikszam, double maszikszam)
        {
            return egyikszam + maszikszam;
        }

        public static double Kivon(double egyikszam, double maszikszam)
        {
            return egyikszam - maszikszam;
        }
    }
}
