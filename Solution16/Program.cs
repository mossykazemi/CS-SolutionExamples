using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution16
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<int>();
            Console.WriteLine("Enter some numbers Sperated by hyphen :");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                Console.WriteLine("bye");
            else
            {
                var numbers = input.Split('-');
                foreach (var i in numbers)
                    numList.Add(Convert.ToInt32(i));
                numList.Sort();
                var isDuplicate = true;
                if (numList.Distinct().Count() != numList.Count)
                    isDuplicate = true;
                else
                    isDuplicate = false;
                Console.WriteLine(isDuplicate ? "Duplicate" : "Not Duplicate");
            }
        }
    }
}
