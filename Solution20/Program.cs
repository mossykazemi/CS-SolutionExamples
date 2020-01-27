using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solution20
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\mkaze\Desktop\Secret.txt";
            var text = File.ReadAllText(path);
            var word = text.Split(' ');
            Console.WriteLine(word.Length);
        }
    }
}
