namespace LeetCode;

public class P0001TwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[]{};
    }

    [Theory]
    [InlineData(new[]{2,7,11,15}, new[] {0,1}, 9)]
    [InlineData(new[]{3,2,4}, new[] {1,2}, 6)]
    [InlineData(new[]{3,3}, new[] {0,1}, 6)]
    public void Test(int[] nums, int[] expected, int target)
    {
        Assert.Equal(expected, TwoSum(nums, target));
    }
}