using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution5
{
    //Finding Divisible numbers by 3 betwen 1 and 100
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
