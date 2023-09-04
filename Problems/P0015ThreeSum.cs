using System.Linq;

namespace LeetCode.Problems;

public class P0015ThreeSum
{
    public List<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        if (nums.Length <= 2) return result;
        
        Array.Sort(nums);

        var start = 0;

        while (start < nums.Length - 2)
        {
            var target = nums[start] * -1;
            var left = start + 1;
            var right = nums.Length - 1;

            while ( left < right)
            {
                if (nums[left] + nums[right] > target)
                {
                    --right;
                } else if (nums[left] + nums[right] < target)
                {
                    ++left;
                }
                else 
                {
                    var oneSolution = new List<int>() { nums[start], nums[left], nums[right] };
                    result.Add(oneSolution);


                    while (left < right && nums[left] == oneSolution[1])
                        ++left;

                    while (left < right && nums[right] == oneSolution[2])
                        --right;
                }
            }
            var currentStartNumber = nums[start];
            while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                ++start;
        }
        return result;
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] nums, List<IList<int>> expected)
    {
        Assert.Equal(ThreeSum(nums), expected);
    }
    
    public static IEnumerable<object[]> Data()
    {
        yield return new object[]
        {
            new[] { -1, 0, 1, 2, -1, -4 },
            new List<IList<int>>
            {
                new List<int>() { -1, -1, 2 },
                new List<int>() { -1, 0, 1 }
            }
        };
        yield return new object[]
        {
            new[] { 0, 1, 1 },
            new List<IList<int>> ()
        };
        yield return new object[]
        {
            new[] { 0, 0, 0 },
            new List<IList<int>>
            {
                new List<int>() { 0, 0, 0 }
            }
        };
    }
}