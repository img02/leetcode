public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
    
        for( int l = 0, r = numbers.Length-1; l < r; ){
            var total = numbers[l] + numbers[r];
            if (total == target) return new int[]{l+1, r+1};
            if (total > target) r--;
            else l++;
        }

        return new int[]{};        
    }
}