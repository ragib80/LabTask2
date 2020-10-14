using System;

namespace ProblemSolve5_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n;

            for (i = 1; i <= 5; i++)
            {
                for (n = 1; n <= i; n++)
                {
                    if (i == n)
                        Console.Write(i);
                    else
                        Console.Write(" ");
                }

                Console.WriteLine(" ");
            }

        }
    }
}
