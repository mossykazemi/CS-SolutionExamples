using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution8
{
    class Program
    {
        // it's like a game that you have to guess the number between 1 to 10 
        // code by Mostafa kazemi
        static void Main(string[] args)
        {
            var random = new Random();
            int randNum = random.Next(1, 10);
            Console.WriteLine(randNum);  
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Guess the random number :");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randNum)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if (i == 4)
                    Console.WriteLine("You Lost!");
                else
                    continue;

            }
        }
    }
}
