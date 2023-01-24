public class Solution {
    public int MaxProfit(int[] prices) {
        var lowest = prices[0];
        var profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < lowest)
            {                
                lowest = prices[i];
                continue;
            }               
                profit = prices[i] - lowest > profit ? prices[i] - lowest : profit;
        }
        
        return profit;          
    }
}