using LeetCode;

public class ValidAnagramTests
{
    private readonly ValidAnagramSolution _solution;

    public ValidAnagramTests()
    {
        _solution = new ValidAnagramSolution();
    }

    [Theory]
    [InlineData("anagram","nagaram")]
    public void ValidAnagram_ReturnTrue(string s, string t)
    {
        // Act
        var actual = _solution.isAnagram(s, t);

        // Assert
        Assert.True(actual);
    }

    [Theory]
    [InlineData("rat","car")]
    [InlineData("ab","a")]
    [InlineData("aacc","ccac")]
    public void ValidAnagram_ReturnFalse(string s, string t)
    {
        // Act
        var actual = _solution.isAnagram(s, t);

        // Assert
        Assert.False(actual);
    }

}
