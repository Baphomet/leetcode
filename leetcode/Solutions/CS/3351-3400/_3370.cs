using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._3351_3400
{
    internal class _3370
    {
        public class Solution 
        {
            public int SmallestNumber(int n)
            { 
                string binary = Convert.ToString(n, 2);
                char[] binaryArray = binary.ToCharArray();
                for (int i = 0; i < binaryArray.Length; i++) 
                {
                    if (binaryArray[i] == '0') 
                    {
                        binaryArray[i] = '1';
                    }
                }
                string sb = new string(binaryArray);
                int r = Convert.ToInt32(sb, 2);
                return r;
            }
        }
        
    }
}
