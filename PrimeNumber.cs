using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public PrimeNumber()
        {
            Console.WriteLine("Enter the Number to check if it is prime or not:");
            int number = int.Parse(Console.ReadLine());
            bool result = IsPrime(number);
            if (result)
            {
                Console.WriteLine("Entered number is Prime number");
            }
            else
            {
                Console.WriteLine("Entered Number is not prime number");
            }
        }
        private bool IsPrime(int number)
        {
            int i, m = 0;
            bool flag = true;
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
