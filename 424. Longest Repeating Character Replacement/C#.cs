public class Solution {
    public int CharacterReplacement(string s, int k) {
        var longest = 1;
        var maxFreq = 0;
        var map = new Dictionary<char,int>();

        var left = 0;
        var right = 0;
        while(right < s.Length ){            
            var c = s[right];
            if (!map.ContainsKey(c)) map[c] = 0;
            map[c]++;
            
            if(map[c] > maxFreq) maxFreq = map[c];
            // total letters, minus max repeating letter, if remaining to be changed is greater than k possible changes
            if ( (right-left+1 - maxFreq ) > k) {
                map[s[left]]--;
                left++;
            }
            else {
                longest = Math.Max(longest, right - left + 1);
            }
                right++;
        }

        return longest;
    }
}
