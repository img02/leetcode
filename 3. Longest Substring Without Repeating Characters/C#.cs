public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var longest = 0;    
        var usedChars = new Queue<char>();

        for (var i = 0; i < s.Length; i++){                      
            while (usedChars.Contains(s[i])){
				//longest = Math.Max(longest, usedChars.Count);
                usedChars.Dequeue();
            }            
            usedChars.Enqueue(s[i]);public class Solution {
    public int LengthOfLongestSubstring(string s) {
      return WithDictionary(s);
      //return WithQueue(s);
    }

    public int WithQueue(string s){
        var longest = 0;    
        var usedChars = new Queue<char>();

        for (var i = 0; i < s.Length; i++){                      
            while (usedChars.Contains(s[i])){
                usedChars.Dequeue();
            }            
            usedChars.Enqueue(s[i]);
            longest = Math.Max(longest, usedChars.Count);
        }
		
        return longest;
    }

    public int WithDictionary(string s){
        var dict = new Dictionary<char,int>();
        var longest = 0;
        var left = 0;

        for(var right = 0; right < s.Length; right++){
            var c = s[right];
            if(dict.ContainsKey(c)){
                // plus one, because we want to start at the next index after dupe
                left = Math.Max(left, dict[c] + 1);
            }
            dict[c] = right;
            longest = Math.Max(longest, right - left + 1);
        }

        return longest;
    }
}
            longest = Math.Max(longest, usedChars.Count);
        }
		
		// could move and repeat longest to reduce amount of times it's evaluated.
		//longest = Math.Max(longest, usedChars.Count);        
        return longest;
    }
}