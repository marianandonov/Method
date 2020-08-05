using System;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Hello(name);
        }

        public static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
