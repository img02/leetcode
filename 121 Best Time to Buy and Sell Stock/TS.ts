function maxProfit(prices: number[]): number {
    let maxProfit = 0;
    let lowestBuyPrice = prices[0];

    for(let i = 0; i < prices.length; i++){
       if(prices[i] < lowestBuyPrice) {
        lowestBuyPrice = prices[i];
        continue;
       }

       const profit = prices[i] - lowestBuyPrice;
       maxProfit = Math.max(profit, maxProfit);
    }

    return maxProfit;
    
};