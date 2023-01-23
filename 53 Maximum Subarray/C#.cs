public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 1) return nums[0];

        var currMax = nums[0];
        var runningMax = currMax;

        for (int i = 1; i < nums.Length; i++)
        {
            var value = nums[i];
            currMax = Math.Max(currMax + value, value);
            runningMax = Math.Max(currMax, runningMax);
        }

        return runningMax;
    }
}