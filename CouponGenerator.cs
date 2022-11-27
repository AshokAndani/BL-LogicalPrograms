using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumberGenerator
    {
        public CouponNumberGenerator()
        {
            Console.WriteLine("enter the number of distinct Coupon number you Want: ");
            string[] coupons = Coupon(int.Parse(Console.ReadLine()));
            foreach (String value in coupons)
            {
                Console.WriteLine("the coupon number generated is : " + value);
            }

        }
        public string[] Coupon(int n)
        {
            string[] Array = new string[n];
            int i = 0;
            while (i < n)
            {
                String value = "";
                value = value + BigChar() + IntRange(500, 10000) + BigChar() +
                   IntRange(1000, 2000);
                foreach (string checking in Array)
                {
                    if ((value.Equals(checking)))
                    {
                        i--;
                    }
                }
                Array[i++] = value;
            }
            return Array;
        }
        private int IntRange(int a, int b)
        {
            Random r = new Random();
            return r.Next(a, b);
        }
        private string BigChar()
        {
            char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Random r = new Random();
            int loop = r.Next(1, 11);
            string finalString = "";
            for (int i = 0; i < loop; i++)
            {
                int randomNumber=r.Next(0, 26);
                finalString+=alpha[randomNumber];
            }
            return finalString;
        }
    }
}
