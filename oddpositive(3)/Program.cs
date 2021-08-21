using System;

namespace oddpositive
{
    class Program
    {
        static void Main(string[] args)//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        {
            Console.WriteLine("Введите число! Для завершения операции введите 0!");
            var number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                if ((number % 2) == 0 && number > 0){
                    sum = sum + number;
                }
                Console.WriteLine("Введите ещё число!");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Сумма введённых вами положительных нечетных чисел = {sum}");
            Console.ReadLine();
        }
    }
}
