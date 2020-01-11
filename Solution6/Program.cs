using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write ok to get sum of all inputs
            List<string> enteredNums = new List<string>();

            Console.WriteLine("Enter some values:\n");  //Display an intro line, \n make a new line
            var result = "";
            string input = "";                      //Declare and initialise an empty string
            var exit = "ok";
            do
            {
                input = Console.ReadLine();
                enteredNums.Add(input);
            }
            while (input != exit);
            if (input == exit)
            {
                enteredNums.Remove(input);
                List<int> intList = new List<int>();

                foreach (String s in enteredNums)
                {
                    intList.Add(int.Parse(s));
                }
                Console.WriteLine(intList.Sum());


                //List<int> Result = enteredNums.ConvertAll(int.Parse).ToList();
                //result = Result.Sum();
                //Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
