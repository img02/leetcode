func intersect(nums1 []int, nums2 []int) []int {
    doublesCount := make(map[int]int, 0)
    doubles := make([]int, 0)

    // add a count for each number in nums1
    for _, v := range nums1 {
        // if key 'v' doesn't exist, count defaults to the 'zero value' of int
        // which is 0
        count := doublesCount[v]
        doublesCount[v] = count + 1
    }

    // check each number in nums2 against the 'doublesCount' of nums1
    for _, v := range nums2 {
        count := doublesCount[v]
        // add number to doubles arr
        // reduce count by 1
        if count > 0 {
            doubles = append(doubles, v)
            doublesCount[v] = count - 1
        }
    }

    return doubles
}