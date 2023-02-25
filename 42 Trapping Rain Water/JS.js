/**
 * @param {number[]} height
 * @return {number}
 */
var trap = function(height) {
    let l = 0;
    let r = height.length-1;
    let heightL = height[l];
    let heightR = height[r];
    let water = 0;

    while (l < r) {
        if (height[l] <= height[r]) l++
        else r--;

        // if current elevation lower than relevant boundary, 
        // update water content, else update boundary height.
        if (height[l] < heightL) water += heightL - height[l];
        else heightL = height[l];

        if (height[r] < heightR) water += heightR - height[r];
        else heightR = height[r];        
    }
    return water;
};