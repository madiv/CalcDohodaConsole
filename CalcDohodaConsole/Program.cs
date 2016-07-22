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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Title = "Калькулятор доходности вклада";
			//Ввод дат открытия и закрытия вклада			
			Console.Write("Введите дату открытия вклада ");
            System.DateTime openDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Введите дату закрытия вклада ");
            System.DateTime closeDate = Convert.ToDateTime(Console.ReadLine());
            if (openDate > closeDate)
            {
                Console.WriteLine("Дата закрытия не может быть раньше даты открытия");
                Console.ReadKey();
                Environment.Exit(0);
            }
             
            System.TimeSpan srok = closeDate.Subtract(openDate);
            double totalDayVklada = srok.TotalDays;
            double mesVklada = totalDayVklada / 30;
            mesVklada = Math.Round(mesVklada, 0);
            Console.Write("Введите значение процентной ставки ");
            double stavka = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сумму вклада ");
            double vklad = Convert.ToDouble(Console.ReadLine());
            Console.Write("Капитализация процентов (да/нет) ");
            string kapital = Console.ReadLine();
                       
            if (kapital == "да")
            {
                double effectProcent = (1 + stavka / 1200);
                effectProcent = Math.Pow(effectProcent, mesVklada);
                effectProcent = effectProcent - 1;
                effectProcent = effectProcent * (12 / mesVklada);
                double dohod = ((vklad * effectProcent) / 365) * totalDayVklada;
                //effectProcent = Math.Pow(effectProcent, 2);
                Console.WriteLine("Срок вклада в днях " + totalDayVklada);
                Console.WriteLine("Эффективная ставка = {0:P}", effectProcent);
                Console.WriteLine("Полученный доход = {0:} " + dohod + "руб.");
                Console.ReadKey();
            }
            if (kapital == "нет")
            {
                vklad = vklad + ((vklad * (stavka / 100)) / 365) * totalDayVklada;
                Console.WriteLine("Срок вклада в днях " + totalDayVklada);
                Console.WriteLine("Cтавка = {0:P}", stavka);
                Console.WriteLine("Сумма вклада = {0:C} ", vklad);
                Console.ReadKey();
            }

            
            

           

                    
        }
    }
}