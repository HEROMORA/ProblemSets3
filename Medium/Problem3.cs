using System;
using System.Linq;

namespace PSETS
{
    class Program
    {
        private static string result(int x, int y)
        {
            if (x % y == 0)
                return "yes";
            return "no";
        }

        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            string[] userinput = Console.ReadLine().Split(' ');
            int[] nums = userinput.Select(int.Parse).ToArray();

            foreach (var n in nums)
            {
                Console.Write("{0} ",result(x, n));
            }
            Console.ReadKey();
        }
    }
}
