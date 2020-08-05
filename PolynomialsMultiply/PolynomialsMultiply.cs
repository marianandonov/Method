using System;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace PolynomialsMultiply
{
    class PolynomialsMultiply
    {
        static void Main(string[] args)
        {
            int n = 0;
            int length1 = TryParse("Enter first arr's length: ", n);
            int[] arr1 = new int[length1];

            for (int i = 0; i < arr1.Length; i++)
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
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
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
            int smallLength = 0, bigLength;
            bool isArrOneBigger = false;
            if (arr1.Length > arr2.Length)
            {
                bigLength = arr1.Length;
                smallLength = arr2.Length;
                isArrOneBigger = true;
            }
            else
            {
                bigLength = arr2.Length;
                smallLength = arr1.Length;
            }

            int[] temp = new int[bigLength];
            List<int[]> list = new List<int[]>();

            for(int i = 0; i < smallLength; i++)
            {
                list.Add(new int[bigLength]);
            }

            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 0; j < list[i].Length; i++)
                {
                    if(isArrOneBigger == true)
                    {
                        list[i][j] = arr1[j] * arr2[i];
                    } else
                    {
                        list[i][j] = arr1[i] * arr2[j];
                    }
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; i++)
                {
                    temp[j] += list[i][j];
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
