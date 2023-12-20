public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var longest = 0;    
        var usedChars = new Queue<char>();

        for (var i = 0; i < s.Length; i++){                      
            while (usedChars.Contains(s[i])){
				//longest = Math.Max(longest, usedChars.Count);
                usedChars.Dequeue();
            }            
            usedChars.Enqueue(s[i]);
            longest = Math.Max(longest, usedChars.Count);
        }
		
		// could move and repeat longest to reduce amount of times it's evaluated.
		//longest = Math.Max(longest, usedChars.Count);        
        return longest;
    }
}