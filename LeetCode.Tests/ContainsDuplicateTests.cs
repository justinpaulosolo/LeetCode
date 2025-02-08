using Xunit;
using LeetCode;

public class SolutionTests
{
    private readonly _solution;

    public SolutionTests()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 })]
    [InlineData(new int[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })]
    public void ContainsDuplicate_ReturnsTrue(int[] nums)
    {
        // Act
        var actual = _solution.ContainsDuplicate(nums);

        // Assert
        Assert.True(actual);
    }
}