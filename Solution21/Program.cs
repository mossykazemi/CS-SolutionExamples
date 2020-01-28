using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution21
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\mkaze\Desktop\Secret.txt";
            var text = File.ReadAllText(path).ToLower();
            var match = Regex.Match(text, "\\w+");
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
