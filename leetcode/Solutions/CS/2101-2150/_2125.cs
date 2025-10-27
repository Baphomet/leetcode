using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._2101_2150
{
    internal class _2125
    {
        public class Solution
        {
            public int NumberOfBeams(string[] bank)
            {
                int beams = 0;
                int prevCount = 0;

                foreach (string row in bank) 
                {
                    int count = 0;

                    foreach (char c in row) 
                    {
                        if (c == '1') 
                        {
                        count++;
                        }
                    }
                    if (count > 0) 
                    {
                        beams += prevCount * count;
                        prevCount = count;

                    }
                }
                return beams;
            }
        }
    }
}
