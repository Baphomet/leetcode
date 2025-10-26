using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._0351_0400
{
    internal class _387
    {
        public class Solution
        {
            public int FirstUniqChar(string s)
            {

                Dictionary<char, int> d = new Dictionary<char, int>();
                

                for (int i = 0; i < s.Length; i++) 
                {
                    
                    char l = s[i];
                    if (d.ContainsKey(l))
                    {
                        d[l] = 0 + 1;
                    }
                    else 
                    {
                        d.Add(l, 0);
                    }

                    if (i == s.Length - 1) 
                    {
                        foreach (var x in d)
                        {
                            if (x.Value == 0) 
                            {
                            return s.IndexOf(x.Key);
                            }

                        }
                    }
                }
                return -1;
            }
        }
    }
}
