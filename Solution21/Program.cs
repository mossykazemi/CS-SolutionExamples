using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Solution21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create secret.txt file on your desktop and put some words in it
            var path = @"C:\Users\yourName\Desktop\Secret.txt";
            //Read all the text and make it lowercase
            var text = File.ReadAllText(path).ToLower();
            //Using regex
            var match = Regex.Match(text, "\\w+");
            //Using Linq and Dictionary
            Dictionary<string, int> freq = new Dictionary<string, int>();
            while (match.Success)
            {
                string word = match.Value;
                if (freq.ContainsKey(word))
                {
                    freq[word]++;
                }
                else
                {
                    freq.Add(word, 1);
                }

                match = match.NextMatch();
            }

            Console.WriteLine("Rank  Word  Frequency");
            Console.WriteLine("====  ====  =========");
            int rank = 1;
            foreach (var elem in freq.OrderByDescending(a => a.Value).Take(3))
            {
                Console.WriteLine("{0,2}    {1,-4}    {2,5}", rank++, elem.Key, elem.Value);
            }
            Console.ReadLine();
        }
    }
}
