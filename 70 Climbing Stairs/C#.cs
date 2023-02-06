public class Solution {
    public int ClimbStairs(int n) {
        return recursive(n);
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
}