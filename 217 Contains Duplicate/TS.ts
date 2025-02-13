function containsDuplicate(nums: number[]): boolean {
    const set: Set<number> = new Set();

    for(let num of nums){
        if (set.has(num)) return true;
        set.add(num);
    }

    return false;
};