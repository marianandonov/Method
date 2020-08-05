using System;

namespace Fact1To100
{
    class Fact1To100
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"!{i} = {Factorial(i)}");
            }
        }

        static double Factorial(double number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
