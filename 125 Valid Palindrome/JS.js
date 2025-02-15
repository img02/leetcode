/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    if (s.length === 0 ) return true;
    s = s.toLowerCase().replace(/[^0-9a-z]/g,"");

    for(let i = 0, j = s.length-1 ; i < j; i++, j--){
        if (s[i] !== s[j]) return false        
    }

    return true;
};