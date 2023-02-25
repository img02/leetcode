public class Solution {
    public int Trap(int[] height) {

        var l = 0;
        var r = height.Length-1;
        var heightL = height[l];
        var heightR = height[r];
        var water = 0;

        while ( l < r) {
            // iterate l/r index
            if (heightL <= heightR) l++;
            else r--;
                        
            // if current elevation lower than boundary, update water content
            // otherwise, update boundary heights
            if (height[l] < heightL) water += heightL - height[l];
            else heightL = height[l];
            
            if (height[r] < heightR) water += heightR - height[r];
            else heightR = height[r];
        }

        return water;       
    }
}