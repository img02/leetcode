/**
 * Definition for isBadVersion()
 * 
 * @param {integer} version number
 * @return {boolean} whether the version is bad
 * isBadVersion = function(version) {
 *     ...
 * };
 */

/**
 * @param {function} isBadVersion()
 * @return {function}
 */
var solution = function(isBadVersion) {
    /**
     * @param {integer} n Total versions
     * @return {integer} The first bad version
     */    
    return function(n) {
        let left = 1;
        let right = n;

        while (left < right)
        {
            const mid = left + (right-left)/2;

            if (isBadVersion(mid))  // move left
                right = mid;                
            else                    // move right
                left = mid+1;            
        }
        
        return Math.floor(left);
    };
};