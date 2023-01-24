func matrixReshape(mat [][]int, r int, c int) [][]int {
    if len(mat)*len(mat[0]) != r*c{
        return mat
    }

    reshaped := make([][]int, r)

    //make r arrays
    for i:= 0; i < r; i++ {
        reshaped[i] = make([]int, c)
    }

    sub, index := 0,0    
    // for each array in mat
    for _, arr := range mat {        
        for _, v := range arr {
            fmt.Println(sub, index)
            reshaped[sub][index] = v
            index++
            if index == c {
                index = 0
                sub++
            }
        }
    }

    return reshaped   
}