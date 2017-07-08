using System;

namespace PSETS
{
    class Program
    {
        private static int power(int x, int y)
        {
            int result = 1;
            for (int i = 0;i < y; i++)
                result *= x;
            return result;
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            string op = Console.ReadLine();
            int result = 0;

            switch(op)
            {
                case("+"):
                    result = x + y;
                    break;
                case("-"):
                    result = x - y;
                    break;
                case("*"):
                    result = x * y;
                    break;
                case("/"):
                    result = x / y;
                    break;
                case("**"):
                    result = power(x, y);
                    break;
            }

            System.Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
