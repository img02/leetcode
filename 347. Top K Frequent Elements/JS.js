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
	  
	  
	  /*
	  // using stack
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
	  */
	  
	   const bucket = new Array(nums.length + 1);
        for(let i = 0; i < bucket.length; i++){
            bucket[i] = [];
        }

        for(const [num, freq] of count){
            bucket[freq].push(num);
        }
         //console.log(bucket);

        const results = [k]
        while(k > 0){
            const values = bucket.pop();
            //console.log(values)
            values.forEach( n => {
                results[k-- -1] = n;
            })
        }        

	  return results;
	};