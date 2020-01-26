using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the input
            Console.WriteLine("Enter an English word :");
            var input = Console.ReadLine();

            // Vowels are 'a', 'e', 'o', 'u', 'i'
            var vowelList = new List<char> { 'a', 'e', 'o', 'u', 'i' };
            var vowels = 0;

            foreach (var letter in input.ToLower())
            {
                if (vowelList.Contains(letter))
                    vowels++;// vowels counter 
            }

            // Show on the console
            Console.WriteLine("There are {0} Vowels in {1}", vowels, input);
            Console.ReadKey();
        }
    }
}
