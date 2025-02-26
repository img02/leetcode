public class Solution {
    public int LengthOfLongestSubstring(string s) {
        return WithDictionary(s);
        //return WithQueue(s);
    }

    
    public int WithDictionary(string s){
        var dict = new Dictionary<char,int>();
        var longest = 0;
        
		var left = 0;
        var right = 0;
         while(right < s.Length){
            var c = s[right];
			//dupe found, move left pointer up
            if(dict.ContainsKey(c)){
                // plus one, because we want to start at the next index after dupe
				// need to check max, 
                // because the OG duped letter's index wasn't updated.
                // so it might not be part of the substring anymore
                // in which case we don't need to move the left pointer
                // e.g. with the string 'abba'
                // once 'b' dupe found, left pointer moved to 2
                // when 'a' dupe found, it's the og 'a' which is no longer part of this subtring
                left = Math.Max(left, dict[c] + 1);
            }
            //add / update letter index
            dict[c] = right;
            
            var substringLength = right - left + 1;
            longest = Math.Max(longest, substringLength);
            right++;
        }

        return longest;
    }

    public int WithQueue(string s){
        var longest = 0;
        var q = new Queue<char>();

        var left = 0;
        var right = 0;
        while(right < s.Length){
            var c = s[right];
            while (q.Contains(c)){
                q.Dequeue();
                left++;
            }
            
            q.Enqueue(c);
            longest = Math.Max(longest, q.Count);
            right++;
        }

        return longest;    
    }
}



