using System;

namespace loginandpass_4_
{
    class Program
    {
        static void Main(string[] args)
        {

            if (loginPass("root", "GeekBrains", 3))
            {
                Console.WriteLine($"Добро пожаловать.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Попытки на ввод логина и пароля закончились.");
                Console.ReadLine();
            }
        }

        static bool loginPass(string login, string password, int maxtrycount)
        {
            int trycount = 1;
            Console.WriteLine("Введите логин.");
            string log = Console.ReadLine();
            Console.WriteLine("Введите пароль.");
            string pass = Console.ReadLine();
            do
            {
                trycount++;
                if (log != login || pass != password)
                {
                    Console.WriteLine("Логин или пароль неверны. Введите логин.");
                    log = Console.ReadLine();
                    Console.WriteLine("Введите пароль.");
                    pass = Console.ReadLine();
                }
                else
                {
                    return true;
                }
            } while (trycount <= maxtrycount);
            return false;
        }
    }
}
