impl Solution {
    pub fn max_area(height: Vec<i32>) -> i32 {
        let mut max:i32 = 0;

        let mut left:usize = 0;
        let mut right:usize = height.len()-1;

        while left < right {
            let length:i32 = (right - left )as i32;
            let shortest:i32 =  std::cmp::min(height[left], height[right]);
            let area = length * shortest;

            max =  std::cmp::max(max, area);

            if (height[left] < height[right]) {
                left += 1;
            } else {
                right -= 1;
            }
        }

         max
    }
}