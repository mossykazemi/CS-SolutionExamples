using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 to 10");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
        }
    }
}
