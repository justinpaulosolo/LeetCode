
namespace LeetCode.Problems;

public class P0121BestTimetoBuyandSellStock
{
    public int MaxProfit(int[] prices)
    {
        var profit = 0;
        var buyPrice = prices[0];

        for (var i = 0; i < prices.Length; i++)
        {
            profit = Math.Max(profit, prices[i] - buyPrice);
            buyPrice = Math.Min(buyPrice, prices[i]);
        }

        return profit;
    }
    
    [Theory]
    [InlineData(new int[] { 7,1,5,3,6,4 }, 5)]
    [InlineData(new int[] { 7,6,4,3,1 }, 0)]
    public void Test(int[] prices, int expected)
    {
        Assert.Equal(MaxProfit(prices), expected);
    }
    
}