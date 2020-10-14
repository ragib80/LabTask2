using System;

namespace ProblemSolve1Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n =500;  //n is 500 here
            
            for (i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                   Console.WriteLine(" " +i);
                }
            }
        }
    }
}
