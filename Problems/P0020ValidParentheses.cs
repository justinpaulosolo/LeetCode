using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class P0020ValidParentheses
    {
        public bool IsValid(string s)
        {
            var map = new Dictionary<char, char>
            {
                {'(', ')' },
                {'[', ']' },
                {'{', '}' },
            };

            var stack = new Stack<char>();

            foreach(var item in s)
            {
                if (map.ContainsKey(item))
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    if (map[stack.Pop()] == item) continue;
                    return false;
                }
            }
            return stack.Count == 0;
        }

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        public void Test(string s, bool expected)
        { 
            Assert.Equal(IsValid(s), expected);
        }
    }

    
}
