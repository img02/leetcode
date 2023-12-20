/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    let longest = 0;
    let queue = [];

    for (let i =  0; i < s.length; i++){
        while (queue.includes(s[i])){
            queue.shift(); //dequeues
        }
        queue.push(s[i]);
        longest = Math.max(longest, queue.length);
    }

    return longest;
};