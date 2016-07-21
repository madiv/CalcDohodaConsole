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
            Console.Write("Введите дату открытия вклада ");
            System.DateTime openDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите дату закрытия вклада ");
            System.DateTime closeDate = Convert.ToDateTime(Console.ReadLine());
            System.TimeSpan srok = closeDate.Subtract(openDate);
            Console.Write("" + srok);




            //DateTime openDate = DateTime.
            Console.Write("Введите значение процентной ставки ");
            double stavka = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сумму вклада ");
            double vklad = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите срок вклада в днях ");
            //double years = 3;
            //double mes = years * 12;
            double dni = Convert.ToDouble(Console.ReadLine());
            double effectProcent = 0;
            double mes = dni / 30;

            effectProcent = (1 + stavka / 1200);
            effectProcent = Math.Pow(effectProcent,mes);
            effectProcent = effectProcent - 1;
            effectProcent = effectProcent * (12 / mes);

            vklad = vklad + ((vklad * effectProcent) / 365) * dni;

            Console.WriteLine("Эффективная ставка = {0:P}", effectProcent);
            Console.WriteLine("Сумма вклада = {0:C} ", vklad);
            Console.ReadKey();        
        }
    }
}