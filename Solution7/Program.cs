using System;

namespace Solution7
{
    class Program
    {
        // Factorial of number Project 
        // it has many ways to code for factorial 
        static void Main(string[] args)
        {
            int i, number, factorial = 1;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(number + "!" + " =" + factorial);
        }
    }
}
