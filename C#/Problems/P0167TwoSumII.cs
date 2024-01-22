namespace LeetCode.Problems;

public class P0001TwoSumII
{
    public int[] TwoSum(int[] numbers, int target)
    {
        for (var i = 0; i < numbers.Length; i++)
            for (var j = i + 1; j < numbers.Length; j++)
                if (numbers[i] + numbers[j] == target)
                    return new[] { i + 1, j + 1 };
        return new int[] { };
    }

    public int[]? TwoSumSolution2(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        while (left <= right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
                return new[] { left + 1, right + 1 };
            if (sum < target)
                left++;
            else
                right--;
        }

        return null;
    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, new[] { 1, 2 }, 9)]
    [InlineData(new[] { 2, 3, 4 }, new[] { 1, 3 }, 6)]
    [InlineData(new[] { -1, 0 }, new[] { 1, 2 }, -1)]
    public void Test(int[] nums, int[] expected, int target)
    {
        Assert.Equal(expected, TwoSum(nums, target));
        Assert.Equal(expected, TwoSumSolution2(nums, target));
    }
}