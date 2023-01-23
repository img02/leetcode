public class Solution {
    public int FindJudge(int n, int[][] trust) {   
        var trustedCount = new int[n, 1];     

        var trustDict = new Dictionary<int,int>();

        if (n == 1) return 1;

        for (int i = 0; i < trust.Length; i++)
        {
            // -1 because n is 1-indexed
            var truster = trust[i][0] -1;
            var trusted = trust[i][1] -1;
    
           trustedCount[trusted,0]++;
           trustedCount[truster,0] = -1;
        }

        for (int i = 0; i < trustedCount.Length; i++)
        {
            // +1 because n is 1-indexed
            if (trustedCount[i,0] == n-1) return i+1;
        }

        return -1;
    }
}