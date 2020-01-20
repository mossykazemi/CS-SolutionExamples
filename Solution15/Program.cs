using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers seperated by hyphen (-):");
            var input = Console.ReadLine();
            var numArray = input.Split('-');
            int firstValue = Convert.ToInt32(numArray[0]);
            bool Cons = true;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (Convert.ToInt32(numArray[i]) != firstValue)
                    Cons = false;
                break;
            }
            var result = Cons ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(result);
            Console.ReadKey();


            //Another way to do it :

            //var numbers = new List<int>();
            //Console.WriteLine("Type a hypen separated numbers list");
            //var input = Console.ReadLine();
            //var numberList = input.Split('-');
            //foreach (var i in numberList)
            //{
            //    numbers.Add(Convert.ToInt32(i));
            //}
            //var isConsecutive = true;
            //numbers.Sort();
            //for (var i = 0; i < numbers.Count - 1; i++)
            //{
            //    if (numbers[i + 1] != numbers[i] + 1)
            //    {
            //        isConsecutive = false;
            //        break;
            //    }
            //}
            //var result = (isConsecutive) ? "Consecutive" : "Non consecutive";
            //Console.WriteLine(result);
            //Console.ReadKey();
        }
    }
}
