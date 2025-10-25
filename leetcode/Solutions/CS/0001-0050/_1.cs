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
                var arr = nums.Select((value, index) => new { value, index })
                    .OrderBy(x => x.value)
                    .ToArray();

                int s = 0; int e = nums.Length - 1;
                while (s < e) 
                {
                    int sum = arr[s].value + arr[e].value;
                    if (sum == target)
                    {
                        return new int[] { arr[s].index, arr[e].index };
                        
                    }
                    else if (sum > target)
                    {
                        e--;
                    }
                    else 
                    {
                        s++;
                    }
                }
                return new int[0];
            }
        }
    }
}
