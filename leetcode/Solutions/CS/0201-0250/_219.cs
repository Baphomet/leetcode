using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._0201_0250
{
    internal class _219
    {
        public class Solution 
        {
            public bool ContainsNearbyDuplicate(int[] nums, int k)
            {
                Dictionary<int, int> v = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++) 
                {
                    if (!v.ContainsKey(nums[i]))
                    {
                        v.Add(nums[i], i);
                    }
                    else
                    {
                        int abs = Math.Abs(i - v[nums[i]]);
                        if (abs > k && i < nums.Length)
                        {
                            v[nums[i]] = i;
                            while (i < nums.Length - 1)
                            {
                                i++;
                                if (v.ContainsKey(nums[i]))
                                {
                                    abs = Math.Abs(i - v[nums[i]]);
                                    if (abs <= k)
                                    {
                                       
                                        return true;
                                    }
                                }
                            }
                            return false;
                        }
                        else if (abs <= k) 
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}
