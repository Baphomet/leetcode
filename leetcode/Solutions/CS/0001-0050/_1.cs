using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._0001_0050
{
    internal class _1
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
               Dictionary<int, int> hash = new Dictionary<int, int>();

                for(int i = 0; i < nums.Length; i++) { 

                    int sum = target - nums[i];

                    if (hash.ContainsKey(sum)) 
                    {
                        return new int[] { hash[sum], i };
                    }
                    if (!hash.ContainsKey(nums[i]))
                    {
                        hash.Add(nums[i], i);
                    }
                }
                return new int[0];

            }
        }
    }
}
