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
                

                int drinkedBottles = numBottles; 

                int newBottles = numBottles / numExchange; 
                drinkedBottles += newBottles;

                int bottlesLeft = numBottles % numExchange;


                bottlesLeft += newBottles;
                if (numBottles % numExchange != 0) 
                {
                    newBottles = bottlesLeft / numExchange;
                    drinkedBottles += newBottles;
                    bottlesLeft = (bottlesLeft % numExchange) + newBottles;
                    while (bottlesLeft >= numExchange) 
                    {
                        bottlesLeft = bottlesLeft / numExchange;
                        drinkedBottles += bottlesLeft;
                    }
                    return drinkedBottles;
                }
                if (numBottles % numExchange == 0) 
                {
                    while (bottlesLeft >= numExchange) 
                    {
                    newBottles = bottlesLeft / numExchange;
                    bottlesLeft = (bottlesLeft - numExchange) + newBottles;
                    drinkedBottles += newBottles;
                    }
                    return drinkedBottles;
                }
                 return drinkedBottles;
            }
            
        }
    }
}
