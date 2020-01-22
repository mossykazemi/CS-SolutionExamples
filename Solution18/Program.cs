using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type your sentence :");
            var input = Console.ReadLine();
            //make the input split by space
            var words = input.ToLower().Split(' ');
            var result = "";
            for (var i = 0; i < words.Length; i++)
            {
                result += words[i][0].ToString().ToUpper() + words[i].Substring(1) + " ";
            }
            Console.WriteLine(result);
        }
    }
}
