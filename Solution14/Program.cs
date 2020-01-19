using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some Numbers : ");
            List<string> entered = new List<string>();
            var input = "";
            var exit = String.IsNullOrEmpty(input);
        start:
            do
            {
                input = Console.ReadLine();
                entered.Add(input);
            }
            while (!exit);
            if (exit)
            {
                List<int> numbers = input.Split(',').Select(int.Parse).ToList();
                if (numbers.Count() < 5 || numbers.Count() <= 0)
                {
                    Console.WriteLine("Invalid List\nPlease try again !");
                    goto start;
                }
                else
                {
                    //Console.WriteLine(numbers.Min()); 
                    numbers.Sort();
                    Console.WriteLine(numbers[0] + "\n" + numbers[1] + "\n" + numbers[2] + "\n");
                }
            }
            Console.ReadKey();
        }
    }
}
