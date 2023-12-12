public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       
       var prefix = new int[nums.Length];
       var postfix = new int[nums.Length];


       prefix[0] = 1;
       postfix[nums.Length-1] = 1;
    
       for (int i = 0, j = nums.Length-1; i < nums.Length && j >= 0; i++, j--)
       {
           if (i > 0) prefix[i] = prefix[i-1] * nums[i-1];

           if (j < nums.Length-1) postfix[j] = postfix[j+1] * nums[j+1];

           //Console.WriteLine($"{prefix[i]}|{postfix[j]}");
       }

       var result = new int[nums.Length];      

       for (int i = 0; i < result.Length; i++){
           result[i] = prefix[i] * postfix[i];
       }

       return result;

    }
}