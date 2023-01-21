func isPalindrome(s string) bool {
    s = strings.ToLower(s)
    s = removeNonAlphanumeric(s)
    
    length := len(s)
    if length <= 1 {
        return true;
    }

    return checkPalindrome(s, length)      
}

func checkPalindrome(s string, length int) bool {
    for i := 0; i < length/2; i++ {
        if s[i] != s[length-(1+i)]{
            return false
            }
    }
    return true
}
func removeNonAlphanumeric(s string) string{
    
    /*
    clean := make([]byte,0)

    for _, v := range s{
        if v >= 'a' && v <= 'z' {
           clean = append(clean, byte(v))
        }
        if v >= '0' && v <= '9' {
            clean = append(clean, byte(v))
        }
    }
    */
    
    //slightly faster but slighty more memory 
    clean := make([]rune,0)
    for _, v := range s{
        if v >= 'a' && v <= 'z' {
           clean = append(clean, v)
        }
        if v >= '0' && v <= '9' {
            clean = append(clean, v)
        }
    }
    return string(clean)

    /* // could also use regex, most likely slower
        var nonAlphanumericRegex = regexp.MustCompile(`[^a-zA-Z0-9 ]+`)
        return nonAlphanumericRegex.ReplaceAllString(str, "")
    */
}