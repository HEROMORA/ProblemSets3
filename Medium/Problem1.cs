using System;

namespace PSETS
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 3 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
