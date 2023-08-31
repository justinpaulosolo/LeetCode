using System.Collections;

namespace LeetCode;

public class P0049GroupAnagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>();
        
        foreach(var item in strs)
        {
            var chars = item.ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);

            if (!dictionary.ContainsKey(sorted)) dictionary[sorted] = new List<string>();
            dictionary[sorted].Add(item);
        }

        return dictionary.Select(kv => kv.Value).ToList<IList<string>>();
    }

    public static IEnumerable<object[]> Data()
    {
        yield return new object[]
        {
            new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
            new List<List<string>>()
            {
                new List<string>() { "eat","tea","ate" },
                new List<string>() { "tan", "nat", },
                new List<string>() { "bat" },
            }
        };
        yield return new object[]
        {
            new string[] { "" },
            new List<List<string>>()
            {
                new List<string>() { "" },
            }
        };
        yield return new object[]
        {
            new string[] { "a" },
            new List<List<string>>()
            {
                new List<string>() { "a" },
            }
        };
    }
    
    [Theory]
    [MemberData(nameof(Data))]
    public void Test(string[] strs, List<List<string>> expected)
    {
        Assert.Equal(GroupAnagrams(strs), expected);
    }
}