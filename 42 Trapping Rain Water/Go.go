func trap(height []int) int {
    // left, right indexes
    l := 0
    r := len(height)-1

    // current highest boundary height L/R
    heightL := height[l]
    heightR := height[r]

    water := 0

    for l < r {
        // prioritise iterating left boundary over right
        if (height[l] <= height[r]) {
             l++
        } else { 
            r--
        }

        // if current elevation level is lower than left/right boundary,
        // add water value, restart loop.
        if (height[l] < heightL) {
            water += heightL - height[l]
            continue;
        } 
        if (height[r] < heightR) {
            water += heightR - height[r]
            continue;
        }

        // if current R/L elevation levels not lower than boundaries,
        // must be equal or greater, so update boundaries.
        heightL = height[l]
        heightR = height[r]
    }
    
    return water
}