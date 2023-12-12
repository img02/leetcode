public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var result = new int[k];
        var count = new Dictionary<int,int>();       

		// get a count of each number
        foreach (var n in nums)
        {
            if (!count.ContainsKey(n)){
                count.Add(n,0);
            }
            count[n]++;
        }

		// use a priority queue with the key (number) as the element, value (count) as priority.
        var pq = new PriorityQueue<int,int>();
        
        foreach (var c in count)
        {
            pq.Enqueue(c.Key, c.Value);
            if (pq.Count > k) pq.Dequeue();
        }       

        while (k > 0) {
            result[k-- -1] = pq.Dequeue();            
        }
		
		
        /* Using stack instead of PriorityQueue, not all languages come with pq built-in 
           
        var freq = new Stack<int>[nums.Length + 1];

        // populate with empty stacks
        for (var i = 0; i < freq.Length; i++)
        {
            freq[i] = new Stack<int>();
        }

        foreach (var c in count)
        {
            freq[c.Value].Push(c.Key);
        }

        // just start at the end of freq, which should be highest frequency values, and work in reverse until K is satisfied
        var freqIndex = freq.Length - 1;
        while (k > 0)
        {
            var list = freq[freqIndex--];
            while (list.Count != 0 && k > 0)
            {
                result[k-- - 1] = list.Pop();
            }
        }

            */

        return result;
    }
}