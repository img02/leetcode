func search(nums []int, target int) int {    
    upper := len(nums)-1
    lower := 0

    for lower < upper {
		// skewing mid index to the right
        index := (lower + upper + 1) / 2

        // if target smaller
        if  target < nums[index] {
            upper = index - 1
        } else {
            // if target NOT smaller than current value, 
            // they must either be equal, or target is bigger
            lower = index
        }  
    }     

    if nums[lower] == target {
        return lower
    }
    return -1  
}