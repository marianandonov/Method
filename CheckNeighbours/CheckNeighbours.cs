using System;
using System.Net.Http.Headers;

namespace CheckNeighbours
{
    class CheckNeighbours
    {
        static void Main(string[] args)
        {
            int n = 0;
            int pos = TryParse("Enter a position for checking: ", n);
            int length = TryParse("Enter arr's length: ", n);
            int[] arr = new int[length];

            for(int i = 0; i < length; i++)
            {
                arr[i] = TryParse($"Enter a value for [{i}]: ", n);
            }

            bool check = Check(arr, pos);
            Console.WriteLine($"Is the number in position {pos} bigger? {check}");
        }

        public static bool Check(int[] arr, int num)
        {

            if(num == 1)
            {
                if (arr[0] > arr[1]) return true;
            } else if(num == arr.Length)
            {
                if (arr[arr.Length - 1] > arr[arr.Length - 2]) return true;
            } else
            {
                for(int i = 1; i < arr.Length - 1; i++)
                {
                    if(num == i)
                    {
                        if (arr[num] > arr[i - 1] && arr[num] > arr[i + 1]) return true;
                    }
                }
            }

            return false;
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
