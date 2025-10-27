using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode.Solutions.CS;
using leetcode.Solutions.CS._0551_0600;
using leetcode.Solutions.CS._0001_0050;
using leetcode.Solutions.CS._0201_0250;
using leetcode.Solutions.CS._0351_0400;
using leetcode.Solutions.CS._2101_2150;


namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new _2125.Solution();
            string[] bank = { "011001", 
                              "000000", 
                              "010100",
                              "001000" };
            solution.NumberOfBeams(bank);
            
        }
    }
}
