public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // product of all excluding curreng
        // is the result of pre and post values of index

        var prefix = new int[nums.Length];
        prefix[0] = 1;
        var postfix = new int[nums.Length];
        postfix[postfix.Length-1] = 1;

        var results = new int[nums.Length];
        results[0] = 1;

        for (var i = 1; i < nums.Length; i++){
            prefix[i] = nums[i-1]*prefix[i-1];
        }

        for (var i = nums.Length-2; i >= 0; i--){
            postfix[i] = nums[i+1]*postfix[i+1];
        }

        for (var i = 0; i < nums.Length; i++){
            results[i] = prefix[i]*postfix[i];
        }
        return results;
        
    }
}


// o(1) space complexity

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // product of all excluding curreng
        // is the result of pre and post values of index
		
        var results = new int[nums.Length];

		// prefix and postfix don't need to be stored in arrays - heap mem
		// can be stored on stack in local variables
		// as they are eached used only once per num / result int, then updated
		
        var prefix = 1;
        for (var i = 0; i < nums.Length; i++){
            results[i] = prefix; // store prefix 
            prefix *= nums[i]; // update prefix product for next loop,
			// pre and post values are the product of all prior numbers to num[index]
			// so num[i+1] pre is num[i] * prefix[i]
			// vice-versa for postfix
        }
        var postfix = 1;
        for (var i = nums.Length -1; i >= 0; i--){ // reverse
            results[i] *= postfix; // update results, prefix * postfix
            postfix *= nums[i]; // update postfix for next loop,  postfix[i] = nums[i+1]* postfix[i+1]
        }

        return results;        
    }
}