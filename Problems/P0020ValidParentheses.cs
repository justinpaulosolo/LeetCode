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
            var map = new Dictionary<char, int>()
            {
                {'(',0 },
                {')',0 },
                {'{',0 },
                {'}',0 },
                {'[',0 },
                {']',0 },
            };

            foreach (var item in s)
            {
                map[item]++;
            }
            int firstValue = map.First().Value;
            bool allValuesSame = map.All(x => x.Value == firstValue);

            return allValuesSame;
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
