using System;

namespace ProblemSolve6_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int n = 6;
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
               

            }

            Console.Write("The Factorial of 6 is: " + a);
        }
    }
}

