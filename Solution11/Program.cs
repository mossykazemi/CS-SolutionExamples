using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution11
{
    class Program
    {
        public static string Reverse(string name)
        {
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            return= new string(array);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name: ");
            var name = Console.ReadLine();

            Console.WriteLine(Reverse(name));
            Console.WriteLine(ReverseName(name));
            Console.ReadKey();
        }
    }
}
