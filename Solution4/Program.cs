using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter SpeedLimit:");
            var speedLimit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the CarSpeed:");
            var carSpeed = Convert.ToDouble(Console.ReadLine());

            if (carSpeed <= speedLimit)
                Console.WriteLine("It's OK");
            else if (speedLimit < carSpeed)
            {
                var demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine("Demerit Points :" + demeritPoints);
                if (demeritPoints >= 12)
                {
                    Console.WriteLine("Your license is Suspended");
                }
            }
            Console.ReadKey();
        }
    }
}
