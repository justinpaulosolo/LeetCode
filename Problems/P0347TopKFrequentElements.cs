namespace LeetCode.Problems;

public class P0347TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();
        var result = new int [k];

        foreach (var num in nums)
            if (!dictionary.ContainsKey(num))
                dictionary.Add(num, 1);
            else
                dictionary[num]++;

        var sortedByValues = dictionary
            .OrderBy(x => x.Value)
            .Select(x => x.Key)
            .TakeLast(k)
            .ToArray();

        for (var i = 0; i < k; i++) result[i] = sortedByValues[i];

        return result;
    }

    [Theory]
    [InlineData(new[] { 1, 1, 1, 2, 2, 3 }, 2, new[] { 2, 1 })]
    //[InlineData(new[]{ 1 }, 1, new[]{ 1 })]
    public void Test(int[] nums, int k, int[] expected)
    {
        Assert.Equal(TopKFrequent(nums, k), expected);
    }
}