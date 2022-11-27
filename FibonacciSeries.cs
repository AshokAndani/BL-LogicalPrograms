﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public FibonacciSeries()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            // 0 and 1 are the starters
            Console.Write(n1 + ", " + n2 + ", ");   
            for (i = 2; i < number; ++i) 
            {
                n3 = n1 + n2;
                Console.Write(n3 + ", ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}