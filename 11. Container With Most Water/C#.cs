public class Solution {
    public int MaxArea(int[] height) {
        var max = 0;

        var left = 0;
        var right = height.Length-1;

        while (left < right){
            var length = right - left;
            var shortest = Math.Min(height[left], height[right]);
            var area = shortest * length;
            max = Math.Max(area, max);

            if (height[left] < height[right]) left++;
            else right--;
        }

        return max;
    }
}