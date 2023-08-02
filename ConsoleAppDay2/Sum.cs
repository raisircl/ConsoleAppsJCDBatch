using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay2
{
    internal class Sum
    {
        static void Main()
        {
            float n1, n2, total;
            Console.WriteLine("Enter 1st Number");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            n2 = Convert.ToSingle(Console.ReadLine());

            total = n1 + n2;

            Console.WriteLine($"The sum is {total}");
            Console.WriteLine($"The sum of {n1} and {n2} is {total}");

        }
    }
}
