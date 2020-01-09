using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the image Width (cm):");
            var width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the image Height (cm):");
            var height = Convert.ToDouble(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("image is Landscape");
            }
            else if (height > width)
            {
                Console.WriteLine("image is Portrait");
            }
            else
            {
                Console.WriteLine("image is Square");
            }
        }
    }
}
