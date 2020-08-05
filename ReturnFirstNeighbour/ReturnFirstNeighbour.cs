using System;

namespace ReturnFirstNeighbour
{
    class ReturnFirstNeighbour
    {
        static void Main(string[] args)
        {
            int n = 0;
            int length = TryParse("Enter arr's length: ", n);
            int[] arr = new int[length];

            for(int i = 0; i < length; i++)
            {
                arr[i] = TryParse($"Enter value for [{i}]: ", n);
            }

            int pos = ReturnFirstCheck(arr);
            Console.WriteLine(pos);
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

        static int ReturnFirstCheck(int[] arr)
        {
            for(int i = 1; i < arr.Length - 1; i++)
            {
                if(arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
