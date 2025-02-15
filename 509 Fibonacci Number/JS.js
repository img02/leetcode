/**
 * @param {number} n
 * @return {number}
 */
var fib = function(n) {
        return recursive(n);
        //return memoize(n);
};

function recursive(n){    
    if (n === 0 || n === 1) return n;       
    return recursive(n-1) + recursive(n-2);
}

const memo = new Map();
function memoize(n){
    if(n === 0) return n;
    if (n === 1 || n === 2) return 1; //because both return 1 val, faster
    if (memo.has(n)) return memo.get(n);

    const res = recursive(n);
    memo.set(n,res);
    return res;
}