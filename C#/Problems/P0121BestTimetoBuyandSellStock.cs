namespace LeetCode.Problems;

public class P0121BestTimetoBuyandSellStock
{
    public int MaxProfit(int[] prices)
    {
        var buyPrice = int.MaxValue;
        var profit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < buyPrice)
            {
                buyPrice = prices[i];
            } else if (prices[i] - buyPrice > profit)
            {
                profit = prices[i] - buyPrice;
            }
        }
        return profit;
    }

    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void Test(int[] prices, int expected)
    {
        Assert.Equal(MaxProfit(prices), expected);
    }

}