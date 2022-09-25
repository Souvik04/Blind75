/*
 * Author: Souvik Ghosh
 * Created: 25-Sep-22
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75
{
    public class Array
    {
        /// <summary>
        /// Ref: https://leetcode.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>Integer array of indices</returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    result[i] = map[target - nums[i]];
                    result[i] = i;
                    return result;
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return result;
        }


    }
}
