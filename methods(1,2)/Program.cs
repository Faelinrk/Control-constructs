using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

        }

        static int nMin(int number1, int number2, int number3) //Написать метод, возвращающий минимальное из трёх чисел.
        {
            var min = number1;
            if (number2 < number1){
                min = number2;
            }else if (number3 < number1){
                min = number1;
            }
            return min;
        }

        static int nCount(int number) //Написать метод подсчета количества цифр числа.
        {
            int count = number.ToString().Length;
            return count;
        }

    }
}
