public class Solution {
    public int Fib(int n) {
        //return recursive(n);
        //return memoization(n);
        return forLoop(n);
    }

    private int forLoop(int n){
        if (n == 0) return 0;
        if (n is 1 or 2) return 1;
        var first = 1;
        var second = 1;

        for (int i = 3; i < n; i ++)
        {
            (first, second) = (second, first+second);
        }
        return first+second;         
    } 

    private int recursive(int n) {
        if (n is 0 or 1) {
            return n;
        }
        return recursive(n-1) + recursive(n-2);
    }

    private Dictionary<int,int> fibMap = new();

    private int memoization(int n) {
        if (n is 0) {
            return 0;            
        }
        if (n is 1 or 2) {
            return 1;            
        }
        if (fibMap.ContainsKey(n)){
            return fibMap[n];
        }
        fibMap[n] = recursive(n-1) + recursive(n-2);
        return fibMap[n];
    }
}