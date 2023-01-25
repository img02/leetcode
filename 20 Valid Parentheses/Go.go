//using map for matching pairs
func isValid(s string) bool {
    var stack = make([]rune, 0)        
    var count = 0
    pairs := map[rune]rune{
        '(' : ')',
        '[' : ']',
        '{' : '}',
    }

    for _, v := range s {
        if v == '(' || v == '[' || v == '{' {
            stack = append(stack, v)
            count--
            continue
        }

        stackCount := len(stack);
        if stackCount == 0 {
            return false
        }        
        open := stack[stackCount-1];
        stack = stack[:stackCount-1]
        if (pairs[open] != v){
            return false
        }
        count++
    }
    return count == 0
}


//just a buncha ifs
func isValid(s string) bool {
    var stack = make([]rune, 0)
    var count = 0

    for _, v := range s {
        if v == '(' || v == '[' || v == '{' {
            stack = append(stack, v)
            count--
            continue
        }

        stackCount := len(stack);
        if stackCount == 0 {
            return false
        }
        open := stack[stackCount-1];
        stack = stack[:stackCount-1]

        switch v {
            case ')' :
            if open != '('{
                return false
            }
            case ']' :
            if open != '['{
                return false
            }
            case '}' :
            if open != '{'{
                return false
            }
        }
        count++
    }
    return count == 0
}