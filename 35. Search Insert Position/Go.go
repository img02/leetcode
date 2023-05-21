func searchInsert(nums []int, target int) int {
    left, right := 0, len(nums)-1
	
    for left <= right {
        mid := left + (right-left)/2
        val := nums[mid];
		
        if val > target { // shift window left, exclusive
            right = mid-1
        } else if val < target { // shift window right, exclusive
            left = mid+1
        } else {
            return mid
        }
    }
	
    return left
}