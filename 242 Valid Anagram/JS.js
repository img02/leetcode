/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function(s, t) {
    if (s.length != t.length) return false;

    const alphabet = new Array(26).fill(0);

    for(let c of s){
        alphabet[c.charCodeAt(0) - 'a'.charCodeAt(0)]++;
    }
    for (let c of t){
        alphabet[c.charCodeAt(0) - 'a'.charCodeAt(0)]--;
    }
    for (let n of alphabet){
        if (n !== 0) return false;
    }

    return true;
};