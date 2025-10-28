using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._1501_1550
{
    internal class _1518
    {
        public class Solution
        {
            public int NumWaterBottles(int numBottles, int numExchange)
            {
                int drunk = numBottles;
                int empty = numBottles;
                int reminder = 0;

                while ((empty / numExchange) >= 1) 
                { 
                reminder = empty % numExchange;
                drunk = drunk + (empty / numExchange);
                empty = (empty / numExchange) + reminder;
                }
                return drunk;
            }
            
        }
    }
}
