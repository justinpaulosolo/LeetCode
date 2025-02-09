using Xunit;
using LeetCode;

public class TwoSumTests
{
    private readonly TwoSumSolution _solution;

    public TwoSumTests()
    {
        _solution = new TwoSumSolution();
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_ReturnsCorrectIndices(int[] nums, int target, int[] expected)
    {
        // Act
        var actual = _solution.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}