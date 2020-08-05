using System;

namespace SumArray
{
    class SumArray
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[10000];
            int[] num2 = new int[10000];

            string result = SumArrays(num1, num2);
            Console.WriteLine(result);

        }

        static ulong TryParse(string message, ulong num)
        {
            bool tryParse = false;

            do
            {
                Console.Write(message);
                tryParse = ulong.TryParse(Console.ReadLine(), out num);
                if (tryParse == true) return num;
                else Console.WriteLine("Try Again!");
            } while (tryParse == false);

            return num;
        }

        static string SumArrays(int[] arr1, int[] arr2)
        {
            string res = "";
            ulong n = 0, n1 = 0, n2 = 0;

            n1 = TryParse("Enter first number (n > 0): ", n);
            n2 = TryParse("Enter second number (n > 0): ", n);

            string num1 = n1.ToString();
            string num2 = n2.ToString();

            for(int i = 0; i < num1.Length; i++)
            {
                arr1[i] = num1[i];
            }
            for(int i = num1.Length; i < arr1.Length; i++)
            {
                arr1[i] = 0;
            }

            Array.Reverse(arr1);

            for (int i = 0; i < num2.Length; i++)
            {
                arr2[i] = num2[i];
            }
            for (int i = num2.Length; i < arr2.Length; i++)
            {
                arr2[i] = 0;
            }

            Array.Reverse(arr2);

            ulong res1 = Convert.ToUInt64(string.Join("", arr1));
            ulong res2 = Convert.ToUInt64(string.Join("", arr2));

            ulong sum = res1 + res2;

            return res = sum.ToString();
        }
    }
}
