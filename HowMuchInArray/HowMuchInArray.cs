using System;

namespace HowMuchInArray
{
    class HowMuchInArray
    {
        static void Main(string[] args)
        {
            int n = 0;
            int num = TryParse("Enter a number to be checked: ", n);
            int length = TryParse("Enter arry's length: ", n);

            int[] arr = new int[length];
            for(int i = 0; i < length; i++)
            {
                arr[i] = TryParse($"Enter a num for[{i}] ", n);
            }

            int count = CountNum(arr, num);
            Console.WriteLine($"The number {num} is met {count} times!");
            
        }

        public static int CountNum(int[] arr, int num)
        {
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(num == arr[i])
                {
                    count++;
                }
            }

            return count;
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

    }
}
