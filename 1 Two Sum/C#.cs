public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       var compliments = new Dictionary<int, int>();
       var results = new int[2];

       for (int i = 0; i < nums.Length; i++)
       {
           // num required to pair with nums[i] to complete target
           var diff = target - nums[i];
           
           // if dict already has, return indexes
           if (compliments.ContainsKey(diff))
           {
               results[0] = compliments[diff];
               results[1] = i;
               return results;
           }
           compliments[nums[i]] = i;
       }
       return results;
    }
}