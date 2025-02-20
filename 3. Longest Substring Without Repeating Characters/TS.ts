function lengthOfLongestSubstring(s: string): number {
    return withMap(s);
    //return withQueue(s);
};


function withMap(s: string) : number {
    const map = new Map<string,number>();
    let longest = 0;
    let left = 0;

    for(let right = 0; right < s.length; right++){
        if(map.has(s[right])){
            //update left index to be found letter index + 1 or self if greater.
            left = Math.max(left, map.get(s[right])+1);
        }
        // update dupe char index to furthest one
        map.set(s[right],right);
        longest = Math.max(longest, right - left + 1);
    }

    return longest;
}

function withQueue(s: string) : number {
    const q :string[] = []; 
    let longest = 0;

    for(let c of s){
        while(q.includes(c)){
            q.shift();
        }
        q.push(c);
        longest = Math.max(longest, q.length);
    }
    return longest;
}
// loop thru characters
// if exists in queue
// dequeue until gone
// add char to queue
// update maxlongest against q count
//return longest