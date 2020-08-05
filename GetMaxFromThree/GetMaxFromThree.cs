using System;

namespace GetMaxFromThree
{
    class GetMaxFromThree
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0;
            num1 = TryParse("Enter your first num: ", num1);
            num2 = TryParse("Enter your second num: ", num2);
            num3 = TryParse("Enter your third num: ", num3);

            int res1 = GetMax(num1, num2);
            int res2 = GetMax(res1, num3);

            Console.WriteLine("Max: {0}", res2);
        }

        public static int TryParse(string message, int num)
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

        public static int GetMax(int num1, int num2)
        {
            int maxNum = Math.Max(num1, num2);
            return maxNum;
        }
    }
}
