func myAtoi(s string) int {

    if (len(s) == 0){
         return 0
    }
    
    numByteArr, hasSign := extractNumFromString(s)
    sign := 1
    num := 0

    length := len(numByteArr)
    for i:= 0; i < length; i++ {
        v := int(numByteArr[i])

        if hasSign {
            if v == 45 { //minus sign ascii
                sign = -1
            }
            hasSign = false
            continue
        }

        if (length == 1){
            num += v-48 //ascii 0 starts at 48
            continue
        }
        
        if (v-48 == 0 && num == 0){
            continue
        }

        pow := length - (i+1)
        multiply := 1

        for ; pow > 0; pow-- {
            multiply *= 10
        }

        num += ((v-48)*multiply)
    }

    result := num*sign
    
    if (result > math.MaxInt32){
        result = math.MaxInt32
    }
    if (result < math.MinInt32){
        result = math.MinInt32
    }
        
    return result
}

func extractNumFromString(s string) ([]byte, bool){
    plusMinus := false
    containsNonZeroNum := false
    num := make([]byte, 0)
    count := 0
    for _, v := range s{

    //fmt.Printf("Count: %v | i: %v | v : %v\n ", count, i, v)
        // too long, past int32 max/min length
        // no need to read in more values
        if (count >= 11){ 
            break
        }
        //remove leading whitespace
        if (v == ' '  && len(num) == 0){
            continue
        }
        // if char not a number, and not + / -
        // or is +/- but already found before
        if (v < '0' || v > '9') && (plusMinus || (v != '+' && v != '-')){
            break
        }
        if (plusMinus && (v == '+' || v == '-')){
            break
        }

        if (!plusMinus && (v == '+' || v == '-')){
            if (len(num) > 0) {
                break
            }

            plusMinus = true
            num = append(num, byte(v))
        }

        //if leading 0s, append but don't increase count
        if v == '0'{
            fmt.Println("hello")
            if (!containsNonZeroNum){
                num = append(num, byte(v))
                continue
            }
        }        

        if v >= '0' && v <= '9' {            
            num = append(num, byte(v))
            containsNonZeroNum = true
            count++
        }


    }

    return num, plusMinus
}