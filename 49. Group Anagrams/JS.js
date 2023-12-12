/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
    let matches = new Map();

    strs.forEach(s => {
        let hash = Array(26).fill('q'); //start with random character
        [...s].forEach(c => {
        
        // messy...
        // get char, +1 to char code, get char from code, replace in array...
        let val = hash[c.charCodeAt() - 'a'.charCodeAt()];
        val = String.fromCharCode(val.charCodeAt()+1);
        hash[c.charCodeAt() - 'a'.charCodeAt()] = val;

        });        

        let key = hash.join("");

        if (!matches.has(key)){
            matches.set(key, []);            
        }
        matches.get(key).push(s);
    })

    let result = [];

    matches.forEach(l => {
        result.push(l);
    })

    return result;
};