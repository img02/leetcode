public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        if (mat.Length*mat[0].Length != r*c){
            return mat;
        }

        var reshaped = new int[r][];
        for (int i = 0; i < r; i ++)
        {
            reshaped[i] = new int[c];
        }

        var sub = 0;
        var index = 0;

        foreach (var arr in mat)
        {
            foreach (var num in arr)
            {
                reshaped[sub][index] = num;
                index++;
                if (index == c)
                {
                    index = 0;
                    sub++;
                }
            }            
        }
        return reshaped;        
    }
}