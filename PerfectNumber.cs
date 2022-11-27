using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public PerfectNumber()
        {
            Console.WriteLine("Enter a number to check if it is Perfect number or not:");
            int number = int.Parse(Console.ReadLine());
            bool result = IsPerfectNumber(number);
            if (result)
            {
                Console.WriteLine("Entered number is perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
        }
        private bool IsPerfectNumber(int number)
        {
            int sum = 0, n;
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

    }
}
