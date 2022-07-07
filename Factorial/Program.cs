using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factorial Program In C#

            /*   Console.WriteLine("enter number");
              int n = int.Parse(Console.ReadLine());
              int fact = 1;
              for (int i = 1; i <= n; i++)
              {
                  fact = fact * i;
              }
              Console.WriteLine(fact);*/

            // find out Odd and even in C#

            /*  Console.WriteLine("enter number");
              int n = int.Parse(Console.ReadLine());
              if (n % 2 == 0)
              {
                  Console.WriteLine("even");
              }
              else
              {
                  Console.WriteLine("odd");
              }*/

            // login from in C#

            /*Console.WriteLine("enter  Email");
            string Email = Console.ReadLine();
            Console.WriteLine(" enter Password");
            int Pass = int.Parse(Console.ReadLine());
            string Email1 = "naman@123";
            int Pass1 = 123456;
            if (Email == Email1 || Pass == Pass1)
            {
                Console.WriteLine(" welcome Naman");
            }
            else
            {
                Console.WriteLine("data not found");
            }*/

            // Fibonacci Series in C#
            /* int a = 0;
             int b = 1;
             int c;
             Console.WriteLine(a);
            // Console.WriteLine(b);
             for (int i = 0; i <= 10; i++)
             {
                 c = a + b;
                 Console.WriteLine(c);
                 a = b;
                 b = c;
             }*/

            //count the string length

            /* string n = "Naman Deewaker";
            Console.WriteLine(n.Length);*/

            // find prime or not prime number

            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }


            Console.ReadLine();
        }
    }
}
