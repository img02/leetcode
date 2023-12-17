func maxArea(height []int) int {
    max, left, right := 0, 0, len(height)-1;

    for left < right {
        length := right - left;

        shortest := 0
        if height[left] <= height[right] {
            shortest = height[left];
        } else {
            shortest = height[right];
        }

        area := shortest * length;
        
        if area > max {
            max = area;
        } 

        if height[left] < height[right] {
            left++;
        } else {
            right--;
        }        
    }

    return max;
}