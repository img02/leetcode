function containsNearbyDuplicate(nums: number[], k: number): boolean {
    const set: Set<number> = new Set();

    for(let i = 0; i < nums.length; i++){
        if (set.has(nums[i])) return true;
        set.add(nums[i]);
        if (set.size > k-1){
            set.delete(nums[i-k]);
        }
    }

    return false;
};