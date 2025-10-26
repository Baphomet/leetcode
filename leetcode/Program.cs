using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode.Solutions.CS;
using leetcode.Solutions.CS._0551_0600;
using leetcode.Solutions.CS._0001_0050;
using leetcode.Solutions.CS._0201_0250;


namespace leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new _219.Solution();
            int[] nums = { 1, 2, 3, 1 };
            solution.ContainsNearbyDuplicate(nums, 3);
        }
    }
}
