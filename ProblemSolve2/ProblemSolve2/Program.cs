using System;

namespace ProblemSolve2
{
    
        class Program
        {
            static void Main(string[] args)
            {
                string n = "X0X0X0";

                string r = "";

                Console.WriteLine(n);

                for (int i = n.Length - 1; i >= 0; i--)
                {
                    r = r + n[i];
                }

                Console.WriteLine(r);

                string a = n;
                string r2 = " ";
                Console.WriteLine(a);

                for (int i = a.Length - 1; i >= 0; i--)
                {
                    r2 = r2 + a[i];
                }
                Console.WriteLine(r);

            }
        }
    

}
