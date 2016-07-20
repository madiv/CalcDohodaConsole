using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDohodaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double stavka = 6.3;
            double vklad = 100000;
            double mes = 36;
            double effectProcent = 0;

            effectProcent = (1 + stavka / 1200);
            effectProcent = Math.Pow(effectProcent,mes);
            effectProcent = effectProcent - 1;
            effectProcent = effectProcent * (12 / mes);
            

            
        }
    }
}
