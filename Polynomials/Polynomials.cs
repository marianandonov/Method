using System;

namespace Polynomials
{
    class Polynomials
    {
        static void Main(string[] args)
        {
            int n = 0;
            int length1 = TryParse("Enter first arr's length: ", n);
            int[] arr1 = new int[length1];

            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = TryParse($"[{i}]: ", n);
            }

            int lenght2 = TryParse("Enter second arr's length: ", n);
            int[] arr2 = new int[lenght2];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = TryParse($"[{i}]: ", n);
            }

            PolynomialFirst(arr1);
            PolynomialSecond(arr2);

            int[] temp = PolynomialCalc(arr1, arr2);
            PolynomialResult(temp);
            
        }

        static void PolynomialFirst(int[] arr)
        {
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write($" - {Math.Abs(arr[0])}] + ");
                    }
                    else
                    {
                        Console.Write($" + {arr[0]}] + ");
                    }
                } 
                else if(i == arr.Length - 1)
                {
                    if(arr[i] < 0)
                    {
                        Console.Write($"[- {Math.Abs(arr[i])}x({i})");
                    } else
                    {
                        Console.Write($"[{arr[i]}x({i})");
                    }
                }
                else
                {
                    if(arr[i] < 0)
                    {
                        Console.Write($" - {Math.Abs(arr[i])}x({i})");
                    }
                    else
                    {
                        Console.Write($" + {arr[i]}x({i})");
                    }
                }
            }
        }

        static void PolynomialSecond(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write($" - {Math.Abs(arr[0])}] = ");
                    }
                    else
                    {
                        Console.Write($" + {arr[0]}] = ");
                    }
                }
                else if (i == arr.Length - 1)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write($"[- {Math.Abs(arr[i])}x({i})");
                    }
                    else
                    {
                        Console.Write($"[{arr[i]}x({i})");
                    }
                }
                else
                {
                    if (arr[i] < 0)
                    {
                        Console.Write($" - {Math.Abs(arr[i])}x({i})");
                    }
                    else
                    {
                        Console.Write($" + {arr[i]}x({i})");
                    }
                }
            }
        }

        static int[] PolynomialCalc(int[] arr1, int[] arr2)
        {
            int length = 0;
            bool isArrOneBigger = false;
            if (arr1.Length > arr2.Length)
            {
                length = arr1.Length;
                isArrOneBigger = true;
            }
            else
            {
                length = arr2.Length;
            }

            int[] temp = new int[length];

            if (isArrOneBigger == true)
            {
                temp = arr1;
                for(int i = 0; i < arr2.Length; i++)
                {
                    temp[i] = arr1[i] + arr2[i];
                }
            }
            else
            {
                temp = arr2;
                for(int i = 0; i < arr1.Length; i++)
                {
                    temp[i] = arr1[i] + arr2[i];
                }
            }

            return temp;
        }

        static void PolynomialResult(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write($" - {Math.Abs(arr[0])}]");
                    }
                    else
                    {
                        Console.Write($" + {arr[0]}]");
                    }
                }
                else if (i == arr.Length - 1)
                {
                    if (arr[i] < 0)
                    {
                        Console.Write($"[- {Math.Abs(arr[i])}x({i})");
                    }
                    else
                    {
                        Console.Write($"[{arr[i]}x({i})");
                    }
                }
                else
                {
                    if (arr[i] < 0)
                    {
                        Console.Write($" - {Math.Abs(arr[i])}x({i})");
                    }
                    else
                    {
                        Console.Write($" + {arr[i]}x({i})");
                    }
                }
            }
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
