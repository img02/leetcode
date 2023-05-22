public class Solution {
    public int CountNegatives(int[][] grid) {
    var count = 0;
    for (int i = 0; i < grid.Length; i++)
    {        
        var len = grid[i].Length;
        var left = 0;        
        var right = len-1;
         
        if (grid[i][0] < 0) 
        {
             count+= len;
             continue;
        }
        if (grid[i][len-1] >= 0 ) continue;

        while (left <= right)
        {
            var mid = left + (right-left)/2;
            if (grid[i][mid] >= 0) left = mid+1;
            else right = mid-1;
        }                
        count += len-left;
    }
    return count;
    }
}