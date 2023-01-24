func maxProfit(prices []int) int {
    lowest, profit := prices[0], 0

    for i := 1; i < len(prices); i++ {
        if prices[i] < lowest {
            lowest = prices[i]
            continue
        }

        if prices[i] - lowest > profit {
            profit = prices[i] - lowest
        }
    }
    return profit    
}