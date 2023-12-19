impl Solution {
    pub fn product_except_self(nums: Vec<i32>) -> Vec<i32> {
        let mut answer: Vec<i32> = vec![];

        let mut prefix: i32 = 1;
        for (i, num) in nums.iter().enumerate() {
            answer.push(prefix);
            prefix *= num;
        }
        let mut postfix: i32 = 1;
         for (i, num) in nums.iter().enumerate().rev() {
            answer[i] *= postfix;
            postfix *= nums[i];
        }
        answer
    }
}