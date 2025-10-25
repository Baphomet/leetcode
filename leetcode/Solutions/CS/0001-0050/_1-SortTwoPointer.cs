using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._0001_0050
{
    internal class _1_SortTwoPointer
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                int[] result = new int[2];
                int s = 0; int e = nums.Length - 1;
                Array.Sort(nums);
                while (s <= nums.Length)
                {
                    if (nums[s] + nums[e] > target)
                    {
                        e--;
                    }
                    else if (nums[s] + nums[e] < target)
                    {
                        s++;
                    }
                    else if (nums[s] + nums[e] == target) // ; <- por que sera que ele nao esta entrando no else ne
                    {
                        result[0] = s;
                        result[1] = e;
                        Console.WriteLine(s + "," + e);
                        foreach (int n in result)
                        {
                            Console.WriteLine(n);
                        }
                        break;
                    }
                }
                return result;
            }
        }
    }
}
