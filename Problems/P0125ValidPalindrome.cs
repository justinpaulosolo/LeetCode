namespace LeetCode.Problems;

public class P0125ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var str = s.ToLower();
        var left = 0;
        var right = str.Length - 1;

        while (left <= right)
        {
            if (!char.IsLetterOrDigit(str[left])) left++;
            else if (!char.IsLetterOrDigit(str[right])) right--;
            else
            {
                if (str[left] != str[right]) return false;
                left++;
                right--;
            }
        }
        return true;
    }

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    public void Test(string s, bool expected)
    {
        Assert.Equal(IsPalindrome(s), expected);
    }
}
