namespace LeetCode.Problems;

public class P1480RunningSumOf1dArray
{
    private static int[] RunningSum(int[] nums)
    {
        var total = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            total += nums[i];
            nums[i] = total;
        }
        return nums;
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
    public void Test(int[] nums, int[] expected)
    {
        Assert.Equal(expected, RunningSum(nums));
    }
}