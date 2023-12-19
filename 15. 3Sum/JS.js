/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function(nums) {
    // js sorts lexigraphically? so uhh, use callback, negative return means sort before, pos means goes after
    nums.sort((a, b) => a-b);     
    let results = [];

    for (let i = 0; i < nums.length-2; i++){
        if (i > 0 && nums[i] == nums[i-1]) continue;

        let j = i+1;
        let k = nums.length-1;
        while (j < k){
            let sum = nums[i] + nums[j] + nums[k];
            if (sum == 0){
                results.push([nums[i], nums[j], nums[k]]);
                j++;
                while (j < k && nums[j] == nums[j-1]) j++;
            }
            else if (sum > 0){
                k--;
            }
            else {
                j++;
            }
        }
    }
    return results;
};