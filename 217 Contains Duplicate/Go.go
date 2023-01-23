func containsDuplicate(nums []int) bool {
// use empty struct, since value doesn't matter - uses less mem
 var numMap = make(map[int]struct{}, 0)

 for _, v := range nums{
     // check if key already exists, if so - dupe found
     if _, ok := numMap[v]; ok {
         return true
     }
     numMap[v] = struct{}{}
 }
 return false
}