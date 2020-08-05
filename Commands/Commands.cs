using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Commands
{
    class Commands
    {

        ///

        static void Main(string[] args)
        {
            Start();
        }

        static int TryParse(string message, int num)
        {
            bool tryParse = false;

            do
            {
                Console.Write(message);
                tryParse = int.TryParse(Console.ReadLine(), out num);
                if (tryParse == true) return num;
                else Console.WriteLine("Try Again!");
            } while (tryParse == false);

            return num;
        }

        static uint TryParsePositive(string message, uint num)
        {
            bool tryParse = false;

            do
            {
                Console.Write(message);
                tryParse = uint.TryParse(Console.ReadLine(), out num);
                if (tryParse == true) return num;
                else Console.WriteLine("Try Again!");
            } while (tryParse == false);

            return num;
        }

        static int Reverse()
        {
            int num = 0;
            num = TryParse("Enter your number: ", num);

            string temp = num.ToString();
            char[] arr = temp.ToCharArray();

            Array.Reverse(arr);

            return num = Convert.ToInt32(string.Join("", arr));
        }

        static double Average()
        {
            List<int> list = new List<int>();
            int n = 0;
            n = TryParse("How much numbers would you like to add?: ", n);

            for (int i = 0; i < n; i++)
            {
                list.Add(TryParse($"Enter value for number {i + 1}: ", n));
            }

            double result = list.Average();
            return result;
        }

        static double Equation()
        {
            int n = 0;
            uint nPos = 0;

            uint a = TryParsePositive("Enter the value of A: ", nPos);
            int b = TryParse("Enter the value of B: ", n);

            double x = -b / a;
            return x;
        }

        static void Start()
        {

            int n = 0;

            do
            {
                n = TryParse("Chose a command:\n" +
                "1 - Reverse;\n" +
                "2 - Average;\n" +
                "3 - Equation;\n", n);
            } while (n < 1 || n > 3);

            switch (n)
            {
                case 1:
                    int rev = Reverse();
                    Console.WriteLine("Reverse = " + rev);
                    break;
                case 2:
                    double avr = Average();
                    Console.WriteLine($"Average = {avr}");
                    break;
                case 3:
                    double x  = Equation();
                    Console.WriteLine($"X = {x}");
                    break;
            }
        }

    }
}
