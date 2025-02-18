function topKFrequent(nums: number[], k: number): number[] {
    const count = new Map<number,number>();

    for(const n of nums){
        if(!count.has(n)) count.set(n,0);
        count.set(n, count.get(n)+1);
    }

    // bucket of frequencies, less to more
    const bucket = new Array<number[]>(nums.length +1);
    for(let i = 0; i < bucket.length; i++){
        bucket[i] = [];
    }
    
    for(const [number, freq] of count){
        bucket[freq].push(number);
    }

    const result: number[] = [];
    for (let i = bucket.length-1; i > 0; i--){
        for(const n of bucket[i]){
            result.push(n);
            if (result.length === k) return result;
        }
    }

    return result;
};