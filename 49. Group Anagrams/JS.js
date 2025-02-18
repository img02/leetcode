/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
    let matches = new Map();

    strs.forEach(s => {
        let hash = Array(26).fill(0); 
        
        for( c of s) {        
        hash[c.charCodeAt() - 'a'.charCodeAt()]++;
        };        

        let key = hash.join("-");

        if (!matches.has(key)){
            matches.set(key, []);            
        }
        matches.get(key).push(s);
    })


    return Array.from(matches.values());
};