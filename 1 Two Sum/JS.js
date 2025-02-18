/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
       const compliments = new Map();
        const result = new Array(2);

        for(let i = 0; i < nums.length; i++){
            const val = nums[i];
            compliment = target - val;

            if (compliments.has(compliment)) {
                result[0] = i;
                result[1] = compliments.get(compliment);
                return result;
            }
            compliments.set(val, i);
        }

        return result;
};