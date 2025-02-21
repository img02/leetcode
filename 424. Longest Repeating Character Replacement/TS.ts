function characterReplacement(s: string, k: number): number {
    const map = new  Map<string,number> ();
    let longest = 0;
    let maxFreq = 0;
    let left = 0;
    let right = 0;

    while (right < s.length){
        const c = s[right];
        // update c's count
        if(!map.has(c)) map.set(c,0);
        const count = map.get(c) + 1;
        map.set(c, count);
        //update max freq of repeated char
        if (count > maxFreq) maxFreq = count;

        //check if substring length exceeds max repeated char by k
        const substringLength = right - left + 1;
        if (substringLength - maxFreq > k) {
            const leftCount = map.get(s[left]);
            map.set(s[left], leftCount - 1);
            left++
        } else { //otherwise everything is fine, update longest
            longest = Math.max(longest, substringLength);
        }

        right++
    }

    return longest;
};