namespace LeetCode.Problems;

public class P1929ConcatenationofArray
{
    public int[] GetConcatenation(int[] nums)
    {
        var arr = new int[nums.Length * 2];

        for (var i = 0; i < nums.Length; i++)
        {
            arr[i] = nums[i];
            arr[i + nums.Length] = nums[i];
        }

        return arr;
    }

    [Theory]
    [InlineData(new[] { 1, 2, 1 }, new[] { 1, 2, 1, 1, 2, 1 })]
    [InlineData(new[] { 1, 3, 2, 1 }, new[] { 1, 3, 2, 1, 1, 3, 2, 1 })]
    public void Test(int[] nums, int[] expected)
    {
        Assert.Equal(GetConcatenation(nums), expected);
    }
}