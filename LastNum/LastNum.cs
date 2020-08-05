using System;

namespace LastNum
{
    class LastNum
    {
        static void Main(string[] args)
        {

            int num = 0;
            num = TryParse("Enter a number: ", num);

            Console.WriteLine("Your last number is {0}", ReturnLastNum(num));

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


        public static string ReturnLastNum(int num)
        {
            string result = "";
            string temp = num.ToString();

            switch(temp[temp.Length - 1])
            {
                case '0': result = "zero"; break;
                case '1': result = "one"; break;
                case '2': result = "two"; break;
                case '3': result = "three"; break;
                case '4': result = "four"; break;
                case '5': result = "five"; break;
                case '6': result = "six"; break;
                case '7': result = "seven"; break;
                case '8': result = "eight"; break;
                case '9': result = "nine"; break;
            }

            return result;
        }
    }
}
