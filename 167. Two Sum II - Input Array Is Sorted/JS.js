/**
 * @param {number[]} numbers
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(numbers, target) {
    var compliments = new Map();
    var answer = [];

    for(let i = 0; i < numbers.length; i++){
        const num = numbers[i];
        if (compliments.has(num)){
            answer.push(compliments.get(num) + 1);
            answer.push(i + 1);
            return answer;
        }        
        compliments.set(target - num,i);
    }
    
    return answer;
};