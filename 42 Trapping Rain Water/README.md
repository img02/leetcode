# Trapping Rain Water
## Hard
### https://leetcode.com/problems/trapping-rain-water/
#### O(n)

A basin of water is bounded by a left / right wall, the lower of the two is the max potential water height for each section.  


There is a possible scenario where a higher height boundary does not have a matching boundary, as shown in the example image.  
![image](https://user-images.githubusercontent.com/70348218/221364786-0c5b25ef-4c42-43e1-8d4b-3c2493ab3558.png)

In order to solve this, a solution is to use two pointers, and check from left and right.  

By keeping the state of highest L/R boundaries and interating over the array,  
We can see the minimum boundaries currently existing, which lets us safely assume the water content of each progressive section,  
![image](https://user-images.githubusercontent.com/70348218/221364791-27279949-f5ce-46ea-a44e-808677cbe544.png)


We then iterate the L-index when the L height is <= R height,  
and iterate the R-Index when L height is > R Height.  

![image](https://user-images.githubusercontent.com/70348218/221364994-ba540cc8-47ef-4a01-ab4f-24f33baafba7.png)



