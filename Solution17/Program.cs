using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time value in 24-hour format :");
            var input = Console.ReadLine();
            //split hour and minute with : 
            var time = input.Split(':');
            var hour = Convert.ToInt32(time[0]);
            var minute = Convert.ToInt32(time[1]);
            var IsValid = true;
            if (String.IsNullOrWhiteSpace(input))
                IsValid = false;
            else if (hour > 23 || hour < 00 || minute > 59 || minute < 00)
                IsValid = false;
            else
                IsValid = true;

            var result = (IsValid) ? "Valid" : "Not Valid";
            Console.WriteLine(result);
        }
    }
}
