func isAnagram(s string, t string) bool {
    if len(s) != len(t){
        return false
    }

    alphabet := [26]int{}

    for _, v := range s{
        alphabet[v-'a']++
    }
    for _, v := range t{
        alphabet[v-'a']--
    }
    for _, v := range alphabet{
        if v != 0 {
            return false
        }
    }


/*
    //this seems slightly slower
    //because accessing array each time? idk
    length := len(s)
        for i := 0 ; i < length ; i++ {
            alphabet[s[i] - 'a']++
            alphabet[t[i] - 'a']--
        }
        for _, v := range alphabet{
            if v != 0 {
                return false
            }
        }
    */

    return true
}