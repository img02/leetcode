func twoSum(nums []int, target int) []int {    
    // map contains the compliments required for whole number division
    // for each num
    compliments := make(map[int]int)
    results := make([]int, 2)

    for i, v := range nums {      
        // get the difference needed to complete target sum  
        diff := target - v
        // if required compliment exists in map, return indexes
        if j, ok := compliments[diff]; ok {
           results[0] = j
           results[1] = i
           return results
        }
        // else add the value to the map
        compliments[v] = i
    }

    return results
}