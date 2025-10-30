using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions.CS._0001_0050
{
    internal class _13
    {
        public class Solution 
        {
            public int RomanToInt(string s) 
            {
                Dictionary<char, int> map = new Dictionary<char, int>();
                map.Add('I', 1);
                map.Add('V', 5);
                map.Add('X', 10);
                map.Add('L', 50);
                map.Add('C', 100);
                map.Add('D', 500);
                map.Add('M', 1000);

                char[] arr = s.ToCharArray();
                int sum = 0;
                for (int i = 0; i < arr.Length; i++) 
                {
                    if (i + 1 <= arr.Length - 1)
                    {
                        if (arr[i] == 'I' && (arr[i + 1] == 'V' || arr[i + 1] == 'X'))
                        {
                            sum += map[arr[i + 1]] - map[arr[i]];
                            i++;
                        }

                        else if (arr[i] == 'X' && (arr[i + 1] == 'L' || arr[i + 1] == 'C'))
                        {
                            sum += map[arr[i + 1]] - map[arr[i]];
                        }

                        else if (arr[i] == 'C' && (arr[i + 1] == 'D' || arr[i + 1] == 'M'))
                        {
                            sum += map[arr[i + 1]] - map[arr[i]];
                        }
                        else
                        {
                            sum += map[arr[i]];
                        }
                    }
                    else
                    {
                        sum += map[arr[i]];
                    }
                }
                Console.WriteLine(sum);
                return sum; 
            
            }
        }
    }
}
