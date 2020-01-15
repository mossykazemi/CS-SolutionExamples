using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of your friends who liked your post: ");
            var names = new List<string>();
            while (true)
            {
                var name = Console.ReadLine();
                names.Add(name);

                if (String.IsNullOrEmpty(name))
                {
                    names.Remove(name);
                    break;
                }
            }
            foreach (var item in names)
            {
                Console.WriteLine(" - " + item);
            }
            Console.WriteLine("{0} of your Friends liked your post: ", names.Count);
            Console.ReadKey();
        }
    }
}
