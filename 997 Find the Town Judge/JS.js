/**
 * @param {number} n
 * @param {number[][]} trust
 * @return {number}
 */
var findJudge = function(n, trust) {
    if (n === 1) return 1;
    const trustCount = new Array(n).fill(0);

    for (const [truster, trusted] of trust){
        //-1 because array is 0-indexed and a,b,n is 1-indexed;
        trustCount[truster-1]--;
        trustCount[trusted-1]++;
    }

    for (let i = 0; i < n; i++){            
        if (trustCount[i] === n-1) return i+1;
    }
    
    return -1;
};