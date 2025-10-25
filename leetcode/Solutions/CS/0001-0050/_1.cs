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

                int sum = 0;

                for(int i = 0; i < nums.Length; i++) { 
                    sum = target - nums[i];
                    if (hash.ContainsValue(nums[i])) 
                    {

                        return new int[] {hash.FirstOrDefault(x => x.Value == nums[i]).Key, i};
                    }
                    else
                    {
                       hash.Add(i, sum);
                    }
                }
                return new int[0];

            }
        }
    }
}
