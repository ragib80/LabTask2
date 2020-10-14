using System;

namespace ProblemSolve3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int row = 5;
            int i;
            int j;
            for ( i= 0; i < row; i++)
            {
                for ( j = 0; j < 5; j++)
                {
                    Console.Write(a + j);

                }
                a++;

                Console.WriteLine("");

              
            }
        }
    }
}
