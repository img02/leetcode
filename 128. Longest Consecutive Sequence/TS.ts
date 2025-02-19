function longestConsecutive(nums: number[]): number {
    if (nums.length === 0) return 0;
    const set = new Set(nums);
    let max = 1;
    
    for ( const n of set){
        if (set.has(n-1)) continue;

        let length = 1;
        while (set.has(n+length)) length++;

        max = Math.max(max,length);
    }

    return max;
};