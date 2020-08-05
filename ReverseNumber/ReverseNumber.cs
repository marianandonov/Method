using System;
using System.Linq;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = TryParse("Enter a number: ", n);
            Console.WriteLine("Reverse: {0}", ReverseNum(n));
        }

        static int ReverseNum(int num)
        {
            int res = 0;
            string temp = "";
            int length = num.ToString().Length;

            char[] arr = new char[length];
            for (int i = 0; i < length; i++) arr[i] = num.ToString()[i];
            Array.Reverse(arr);
            for (int i = 0; i < length; i++) temp += arr[i];
            res = Convert.ToInt32(temp);

            return res;
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

    }
}
