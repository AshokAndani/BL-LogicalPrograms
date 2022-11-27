using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Result : "+reverse);
        }

    }
}
