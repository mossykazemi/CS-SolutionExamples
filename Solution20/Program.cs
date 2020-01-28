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
            // you can make a array of splits and put it in text.split 
            var word = text.Split(' ');
            //counting the words is txt with a simple way
            Console.WriteLine(word.Length);
        }
    }
}
