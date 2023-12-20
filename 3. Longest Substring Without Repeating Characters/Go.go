func lengthOfLongestSubstring(s string) int {
    queue := make([]byte,0);
    longest := 0;

    for i := 0; i < len(s); i++ {
        for (slices.Contains(queue, s[i])){
            queue = queue[1:];
        }        
		
        queue = append(queue, s[i]);
        if (longest < len(queue)) {
             longest = len(queue);
        }
    }
	
    return longest;
}