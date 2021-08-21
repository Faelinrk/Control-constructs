using System;

namespace goodnumbers_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine("Программа подсчёта 'Хороших чисел'.");
            Console.WriteLine("Хорошие числа в диапазоне от 1 до 1 000 000.");
            for (int i = 1; i <= 1000000; i++)
            {
                int d = 0;
                for (int k = 0; k < i.ToString().Length; k++)
                {
                    d = d + int.Parse(i.ToString()[k].ToString());
                }
                if (i % d == 0)
                {
                    Console.WriteLine(i);
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Время на выполнение операции: {finish - start}.");
            Console.ReadLine();

        }
    }
}
