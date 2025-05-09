
using System;

namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
            Console.ReadLine(); 
        }

        static long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return -1;
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
