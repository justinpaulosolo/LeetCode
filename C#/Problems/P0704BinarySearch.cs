using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems;
public class P0704BinarySearch
{
    public int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = (right + left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1;
    }

    [Theory]
    [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    public void Test(int[] nums, int target, int expected)
    {
        Assert.Equal(Search(nums, target), expected);
    }
}
