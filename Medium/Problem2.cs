using System;

namespace PSETS
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x % y == 0)
                System.Console.WriteLine("yes");
            else
                System.Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
