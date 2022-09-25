using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75
{
    public class BitManipulation
    {
        /// <summary>
        /// Ref: https://leetcode.com/problems/sum-of-two-integers/
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Sum of a and b</returns>
        public int GetSum(int a, int b)
        {
            int c = 0;

            while (b != 0)
            {
                c = a & b;
                a = a ^ b;
                b = c << 1;
            }

            return a;
        }
    }
}
