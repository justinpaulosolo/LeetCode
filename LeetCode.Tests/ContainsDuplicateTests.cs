using Xunit;
using LeetCode;

public class ContainsDuplicateTests
{
    private readonly ContainsDuplicateSolution _solution;

    public ContainsDuplicateTests()
    {
        _solution = new ContainsDuplicateSolution();
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 })]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })]
    public void ContainsDuplicate_ReturnsTrue(int[] nums)
    {
        // Act
        var actual = _solution.containsDuplicate(nums);

        // Assert
        Assert.True(actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 })]
    [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })]
    public void ContainsDuplicate2_ReturnsTrue(int[] nums)
    {
        // Act
        var actual = _solution.containsDuplicate2(nums);

        // Assert
        Assert.True(actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 })]
    public void ContainsDuplicate2_ReturnsFalse(int[] nums)
    {
        // Act
        var actual = _solution.containsDuplicate2(nums);

        // Assert
        Assert.False(actual);
    }
}