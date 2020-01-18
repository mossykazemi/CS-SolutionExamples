using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution12
{
    class Program
    {
        public static bool ContainsDuplicates(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j]) return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter five numbers: ");
            var numbers = new int[5];
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            numbers[2] = Convert.ToInt32(Console.ReadLine());
            numbers[3] = Convert.ToInt32(Console.ReadLine());
            numbers[4] = Convert.ToInt32(Console.ReadLine());

            ContainsDuplicates(numbers);
            if (ContainsDuplicates(numbers) == true)
            {
                Console.WriteLine("try again");
            }
            else
            {
                Array.Sort(numbers);
                foreach (int x in numbers)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
