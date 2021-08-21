using System;

namespace recursive_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            nRecursive(531, 234) ;
            Console.ReadLine();
        }
        static void nRecursive(int a, int b)
        {
            if (a < b)
            {
                Console.Write(a + " ");
                a++;
                nRecursive(a, b);
            }
            else if (a > b)
            {
                Console.Write(a + " ");
                a--;
                nRecursive(a, b);
            }
            else Console.Write(a + " "); 

        }


    }



}
