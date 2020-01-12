using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();
            var input = "";
            var exit = String.IsNullOrEmpty(input);
            do
            {
                input = Console.ReadLine();
                numbers.Add(input);
            }
            while (!exit);
            if (exit)
            {

                List<int> numsum = input.Split(',').Select(int.Parse).ToList();

                Console.WriteLine("minimum number is : " + numsum.Min());
            }
        }
    }
}
