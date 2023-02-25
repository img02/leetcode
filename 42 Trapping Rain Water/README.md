# Trapping Rain Water
## Hard
### https://leetcode.com/problems/trapping-rain-water/
#### O(n)

A basin of water is bounded by a left / right wall, the lower of the two is the max potential water height for each section.  


There is scenario where an higher height boundary does not have a matching boundary, as shown in the example image.  
img1  

In order to solve, need to use two pointers, and check from left and right.  

By keeping the state of highest L/R boundaries and interating over the array,  
We can see the minimum possible boundaries currently existing, which lets us safely assume the water content of each progressive section,  
img2

We then iterate the L-index when the L height is <= R height,  
and iterate the R-Index when L height is > R Height.  

img3

