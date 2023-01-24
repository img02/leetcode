func generate(numRows int) [][]int {
    triangles := make([][]int, numRows)

    for i := 0; i < numRows; i++ {
        triangles[i] = make([]int, i+1)

        if i <= 1 {
            for j  := range triangles[i]{
                triangles[i][j] = 1
            }
            continue
        }
        
        // i >= 3
        for j := range triangles[i] {
            // first and last = 1
            if (j == 0 || j == len(triangles[i])-1){
                triangles[i][j] = 1
                continue
            }
            // every other value at index j is equal to prev array 
            // at index j-1 + index j
            // e.g. [2][1] == [1][0] + [1][1]
            triangles[i][j] = triangles[i-1][j-1]+triangles[i-1][j]
        }
    }
    return triangles
}