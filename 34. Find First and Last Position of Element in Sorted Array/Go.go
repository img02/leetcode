func searchRange(nums []int, target int) []int {
    left, right := 0, len(nums)-1
    res := []int{-1,-1}

    for left <= right {
        mid := left + (right-left)/2
        val := nums[mid]
		
        if val == target {
            res[0] = mid;
            res[1] = mid;
            break;
        } else if val > target {
            right = mid-1
        } else {
            left = mid+1
        }
    }

    for res[0] > 0 {
        index := res[0] -1 ;
		
        if nums[index] == target {
            res[0] = index;
        } else {
            break;
        }
    }
	
    for res[1] < len(nums)-1 {
        index := res[1] + 1;
		
        if nums[index] == target {
            res[1] = index;
        } else {
            break;
        }
    }

    return res    
}