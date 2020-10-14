using System;

namespace ProblemSolve7_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 4;
            int i;
            int j;
            for (i = 0; i < m; i++)
            {
                for ( j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }
            for ( i = m; i >= 0; i--)
            {
                for ( j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
