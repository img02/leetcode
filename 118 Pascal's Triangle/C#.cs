public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var triangle = new List<IList<int>>();
        var row = 0;

        for (int i = 0; i < numRows; i++)
        { 
            triangle.Add(new List<int>());
            for (int j = 0; j <= i; j++)
            {
                triangle[i].Add(1);
            }
        }

        for (int i = 2; i < numRows; i++)
        {   //0th and nth value are 1, so we skip them
            for (int j = 1; j < triangle[i].Count-1; j++)
            {
                triangle[i][j] = triangle[i-1][j-1] + triangle[i-1][j];
            }
        }
        // mix of .Add() and index access is a bit confusing
        return triangle;
    }
}