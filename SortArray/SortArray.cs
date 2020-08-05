using System;

namespace SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {

            int n = 0;
            int length = TryParse("Enter arr's length: ", n);
            int[] arr = new int[length];

            for(int i = 0; i < length; i++)
            {
                arr[i] = TryParse($"Enter value of [{i}]: ", n);
            }

            Console.WriteLine();3
            
            for(int i = arr.Length; i > 0; i--)
            {
                Console.Write(Sort(arr, i) + " ");
            }

        }

        static int Sort(int[] arr, int counter)
        {
            int num = 0;

            Array.Sort(arr);
           
            return num = arr[counter - 1];
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
