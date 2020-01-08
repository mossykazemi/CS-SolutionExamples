using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
                Console.WriteLine("{0} is Bigger than {1}", num2, num1);
            else if (num2 < num1)
                Console.WriteLine("{0} is Bigger than {1}", num1, num2);
            else if (num1 == num2)
                Console.WriteLine("Numbers are equal");
        }
    }
}
