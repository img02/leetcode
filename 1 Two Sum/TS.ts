function twoSum(nums: number[], target: number): number[] {
    const compliments = new Map<number,number>();
    const result = new Array<number>(2);

    for(let i = 0; i < nums.length; i++){
        const val = nums[i];
        const compliment = target - val;

        if (compliments.has(compliment)){
            result[0] = i;
            result[1] = compliments.get(compliment);
            return result;
        }
        compliments.set(val, i);
    }

    return result;
};