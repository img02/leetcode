func maxSubArray(nums []int) int {
    if len(nums) == 1{
        return nums[0]
    }
    return kadanesAlgo(nums)   
}

func kadanesAlgo(nums []int) int {
    runningMax := nums[0]
    currMax := runningMax

    for i := 1; i < len(nums); i++ {
        v:= nums[i]

        if currMax + v > v {
            currMax += v
        } else {
            currMax = v
        }        

        if currMax > runningMax {
			runningMax = currMax
		}
    }
    
    return runningMax
}