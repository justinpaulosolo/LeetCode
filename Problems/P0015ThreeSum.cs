namespace LeetCode.Problems;

public class P0015ThreeSum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        if (nums.Length <= 2) return result;
        
        Array.Sort(nums);

        int start = 0, left, right;

        int target;

        while (start <= nums.Length - 2)
        {
            
        }

    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] nums, IList<IList<int>> expected)
    {
        Assert.Equal(ThreeSum(nums), expected);
    }
    
    public static IEnumerable<object[]> Data()
    {
        yield return new object[]
        {
            new[] { -1, 0, 1, 2, -1, -4 },
            new List<List<int>>
            {
                new() { -1, -1, 2 },
                new() { -1, 0, 1 }
            }
        };
        yield return new object[]
        {
            new[] { 0, 1, 1 },
            new List<List<int>>
            {
                new()
            }
        };
        yield return new object[]
        {
            new[] { 0, 0, 0 },
            new List<List<int>>
            {
                new List<int>() { 0, 0, 0 }
            }
        };
    }
}