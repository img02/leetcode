/**
 * @param {string} s
 * @param {number} k
 * @return {number}
 */
var characterReplacement = function(s, k) {
    const map = new Map(); // letter, count
    let longest = 0;
    let maxFreq = 0;
    let left = 0;
    let right = 0;

    while(right < s.length){
        const c = s[right];
        //update letter count
        if(!map.has(c)) map.set(c,0);
        const count = map.get(c) + 1;
        map.set(c, count);

        //update max freq
        if(count > maxFreq) maxFreq = count;

        const subStringLength = right-left+1;

        //check if too many letters to replace, reduce left count, increment left pointer
        if ( subStringLength - maxFreq > k) {            
            const leftCount = map.get(s[left]);
            map.set(s[left], leftCount-1);
            left++;
        } //otherwise update longest based on this substring
        else {
            longest = Math.max(longest, subStringLength);
        }

        right++;
    }

    return longest;
};