using System;

namespace imt_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа вычисления индекса массы тела!");
            Console.WriteLine("Пожалуйста, введите ваш вес (в килограммах).");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите ваш рост (в метрах).");
            double h = Convert.ToDouble(Console.ReadLine());
            double imt = m / (h * h);
            double normalm = (h * 70) - 50;
            Console.WriteLine($"Ваш ИМТ = {imt.ToString("F2")}");

            if (imt <= 16) 
            {
                Console.WriteLine($"Выраженный дефицит массы тела. Необходимо набрать {normalm-m} кг.");
            }
            else if (imt > 16 && imt <= 18.5)
            {
                Console.WriteLine($"Недостаточная (дефицит) масса тела. Необходимо набрать {normalm-m} кг.");
            }
            else if (imt > 18.5 && imt <= 25)
            {
                Console.WriteLine("Норма. Так держать!");
            }
            else if (imt > 25 && imt <= 30)
            {
                Console.WriteLine($"Избыточная масса тела (предожирение). Необходимо сбросить {m - normalm} кг.");
            }
            else if (imt > 30 && imt <= 35){
                Console.WriteLine($"Ожирение. Необходимо сбросить {m - normalm} кг.");
            }
            else if (imt > 35 && imt <= 40){
                Console.WriteLine($"Ожирение резкое. Необходимо сбросить {m - normalm} кг.");
            }
            else if (imt > 40){
                Console.WriteLine($"Очень резкое ожирение. Необходимо сбросить {m - normalm} кг.");
            }
            Console.ReadLine();



        }
    }
}
