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
            //Create a text file named secret.txt on desktop and add some words in it
            var path = @"C:\Users\yourname\Desktop\Secret.txt";
            //read all the text in secret.txt file
            var text = File.ReadAllText(path);
            var word = text.Split(' ');
            Console.WriteLine(word.Length);
        }
    }
}
