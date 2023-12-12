public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        var longest = 0;

        foreach (var n in set){
            if (set.Contains(n-1)) continue;
            
            var length = 0;
            while (set.Contains(n+length)){
                length++;
            }
            longest = length > longest ? length : longest;
        }

        return longest;
    }
}