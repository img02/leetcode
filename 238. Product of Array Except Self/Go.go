func productExceptSelf(nums []int) []int {    
    var answer []int;
    
    prefix := 1;
    for i := 0; i < len(nums); i++{
        answer = append(answer, prefix);
        prefix *= nums[i];
    }
    postfix := 1;
    for i := len(nums)-1; i >= 0; i--{
        answer[i] *= postfix;
        postfix *= nums[i];
    }
    return answer;
}