
namespace LeetCode.Problems;

public class P0121BestTimetoBuyandSellStock
{
    public int MaxProfit(int[] prices)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < prices.Length; i++)
        {
            map.Add(prices[i], 0);
            for (var j = i + 1; j < prices.Length; j++)
            {
                var profit = map[prices[i]] - prices[j];
                if (map[prices[i]] < profit)
                {
                    map[prices[i]] = profit;
                }
            }
        }

        return 0;
    }
    
    [Theory]
    [InlineData(new int[] { 7,1,5,3,6,4 }, 5)]
    [InlineData(new int[] { 7,6,4,3,1 }, 0)]
    public void Test(int[] prices, int expected)
    {
        Assert.Equal(MaxProfit(prices), expected);
    }
    
}