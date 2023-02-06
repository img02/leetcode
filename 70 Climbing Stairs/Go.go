func climbStairs(n int) int {
    return recursive(n);
}


// a map of the possible combos to reach 0 from point m
// where n > m > 0
// with steps of -1 or -2
var combos = make(map[int]int)

func recursive(n int) int {
    // if n is negative, invalid combo
    if (n < 0) {
        return 0
    }
    // if n is 0 a valid step for complete combo
    if (n == 0) {
        return 1
    }
    // if the number of possible combos is already recorded
    // return that value
    if v, ok := combos[n]; ok {
        return v
    }
    // otherwise evaluate the possible combinations
    // and add it to the map
    combos[n] = recursive(n-1) + recursive(n-2)
    return combos[n]
}