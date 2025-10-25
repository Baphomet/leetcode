using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._0551_0600
{
    internal class _557
    {
        public class Solution
        {
            public string ReverseWords(string s)
            {
                var result = new StringBuilder();
                
                int l = 0, r = 0;
                while (r < s.Length) 
                {
                    if (s[r] != ' ')
                    {
                        r++;
                    }
                    else 
                    {
                       result.Append(s.Substring(l, r - l).ToCharArray().Reverse().ToArray());
                        result.Append(' ');
                        r++;
                        l = r;
                    }
                }
                result.Append(s.Substring(l, r - l).ToCharArray().Reverse().ToArray());

                return result.ToString();
            }
        }
    }
}
