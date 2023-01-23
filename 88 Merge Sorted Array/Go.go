func merge(nums1 []int, m int, nums2 []int, n int)  {    
    if n == 0 {
        return
    }
    
    merged := make([]int, len(nums1))

    for i, n1, n2 := 0,0,0; i < len(merged); i++ {
        if m > n1 {            
            if n == n2 || nums1[n1] <= nums2[n2] {
            merged[i] = nums1[n1]
            n1++
            continue
            }
        }
        if nums2[n2] < nums1[n1] || nums1[n1] == 0{
            merged[i] = nums2[n2]
            n2++
        }
    }
    
    for i, v := range merged{
        nums1[i] = v
    }
}

func usingStdLib(nums1 []int, nums2 []int, n int){    
    //has edge case issue of nums1 = [0], nums1 = [1], n = 1 
    nums1 = append(nums1[:n], nums2...)    
    sort.Ints(nums1)
}

