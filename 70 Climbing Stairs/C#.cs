public class Solution {
    public int ClimbStairs(int n) {
        //return recursive(n);
        //return dp(n);
		return cleaner(n);
    }

   
    // amount of step combos to reach point m, where n > m > 0
    private Dictionary<int,int> combos = new();

    private int recursive(int n) {
        // if n is below 0, does not count towards possible combos
        if (n < 0) return 0;
        // if n is 0, a complete combo, add one step to previous count
        if (n == 0) return 1;
        // if possible combinations at steps[n] exists, return that value
        if (combos.ContainsKey(n)) return combos[n];
        // else continue to get the possible combos at this number of steps
        combos[n] = recursive(n-1) + recursive(n-2);        
        return combos[n];
    }

    private int dp (int n) {
        // one and two are the combo counts for the 2 previous steps
        // climbing from 0 to n
        // it takes 0 steps to get to step 0
        // it takes 1 step to get to step 1 - from 0        

        // it takes (combos to step 0)+2 to get to step 2
        // it takes (combos to step 1)+1 to get to step 2

        // basically, the combination count for each step is made of of
        // the count for the prior step + (taking 1 step)
        // and the count for the prior-prior step + (taking 2 steps)       
        
        //starting at step 0 and 1
        var one = 0;
        var two = 1;

        for (int i = 0; i < n; i++)
        {
            var temp = two;
            two = one + two;
            one = temp;
        }
        return two;
    }
	
	private int cleaner(int n){
       if (n == 1) return 1;
       if (n == 2) return 2;

       // sum of combos one and two steps before current
       var one = 2;
       var two = 1;

       // stops before n -- so we have the number of combos at n-1 and n-2
       for (int i = 3; i < n; i++){
           (one, two) = (one+two, one);
       }
       return one+two;
    }
}