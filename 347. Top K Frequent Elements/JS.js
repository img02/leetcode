	/**
	 * @param {number[]} nums
	 * @param {number} k
	 * @return {number[]}
	 */
	var topKFrequent = function (nums, k) {
	  let count = new Map();

	  nums.forEach((n) => {
		if (!count.has(n)) {
		  count.set(n, 0);
		}
		count.set(n, count.get(n) + 1);
	  });
	  
	  let stack = Array(nums.length + 1);
	  for (let i = 0; i < stack.length; i++) {
		stack[i] = [];
	  }  

	  count.forEach((key, value) => {
		stack[key].push(value);
	  });	  

	  let freqIndex = stack.length - 1;
	  let results = [k];
	  while (k > 0) {
		stack[freqIndex--].forEach((num)=>{
			results[k-- -1] = num;
		})
	  }

	  return results;
	};