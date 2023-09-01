namespace LeetCode.Problems;

public class P0001TwoSumII
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i+1, j+1};
                }
            }
        }
        return new int[]{};
    }

    [Theory]
    [InlineData(new[]{2,7,11,15}, new[] {1,2}, 9)]
    [InlineData(new[]{2,3,4}, new[] {1,3}, 6)]
    [InlineData(new[]{-1,0}, new[] {1,2}, -1)]
    public void Test(int[] nums, int[] expected, int target)
    {
        Assert.Equal(expected, TwoSum(nums, target));
    }
}
