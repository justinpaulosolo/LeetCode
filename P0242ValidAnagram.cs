namespace LeetCode;

public class P0242ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        var hashmap = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            hashmap.TryAdd(s[i], 0);
            hashmap.TryAdd(t[i], 0);

            hashmap[s[i]]++;
            hashmap[t[i]]--;
        }
        
        return hashmap.Values.All(value => value == 0);
    }
    
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "cat", false)]
    public void Test(string s, string t, bool expected)
    {
        Assert.Equal(IsAnagram(s, t), expected);
    }
}