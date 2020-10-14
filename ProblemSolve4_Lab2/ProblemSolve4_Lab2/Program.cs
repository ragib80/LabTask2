using System;

namespace ProblemSolve4_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumEven = 0;
            int sumOdd = 0;
            int n = 100;
            int i;
         
         

            for ( i = 1; i <n; i++)
            {
                if (i % 2 == 0)
                {

                    sumEven = sumEven + i;
                    Console.WriteLine("even numbers : " + i);
                    Console.WriteLine(" ");
                }
                else
                {
                    sumOdd = sumOdd + i;
                    Console.WriteLine("odd numbers : " + i);
                }

                Console.WriteLine(" ");
            }
            Console.WriteLine("sum off even number : " + sumEven);
            Console.WriteLine("sum off odd number : " + sumOdd);
        }
    }

}
