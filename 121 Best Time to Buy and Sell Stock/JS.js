/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    let maxProfit = 0;
    let lowestBuyPrice = prices[0];

    for(let i = 1; i < prices.length; i++)
    {
        if (prices[i] <= lowestBuyPrice) {
            lowestBuyPrice = prices[i];
            continue;
        }

        const profit = prices[i] - lowestBuyPrice;        
        maxProfit = Math.max(profit, maxProfit);
    }

    return maxProfit;
};
