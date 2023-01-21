func isPalindrome(s string) bool {
    s = strings.ToLower(s)
    l, r := 0, len(s)-1

    for l < r {
        if !isAlphanumeric(s[l]){
            l++
            continue
        }

        if !isAlphanumeric(s[r]){
            r--
            continue
        }
        
        if s[l] != s[r] {
            return false
        }
        l++
        r--
    }
    return true
}


func isAlphanumeric(r byte) bool {
      
        if r >= 'a' && r <= 'z' {
           return true
        }
        if r >= '0' && r <= '9' {
            return true
        }
        return false
}