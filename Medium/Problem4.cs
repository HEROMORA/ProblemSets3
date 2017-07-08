using System;
using System.Linq;

namespace PSETS
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            for(double i = x - 1;i > 0; i--)
            {
                x *= i;
            }
            System.Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
