public class Solution {
    public int CharacterReplacement(string s, int k) {
        var letterCount = new Dictionary<char,int>();
        var longest = 0;
        var mostFreq = 0;

        var left = 0;
        var right = 0;
        while (right < s.Length){
            var c = s[right];
            //updating letter count
            if(!letterCount.ContainsKey(c)) letterCount.Add(c,0);
            letterCount[c]++;

            if(letterCount[c] > mostFreq) mostFreq = letterCount[c];
            
            //check if replacables exceed k
            var substringLength = right - left + 1;
            var replaceables = substringLength - mostFreq;
            
            // dont need to check and update letter count / most freq here
            // because regardless of most freq being no longer accurate
            // right point moves up as well as left -- sliding window
            // so replaceables count will be larger than k
            // until old mostFreq is exceeded by a new substring
            if (replaceables > k){
                letterCount[s[left]]--;
                left++;              
            }            
            else {
            longest = Math.Max(longest, substringLength);
            }

            right++;
        }

        return longest;        
    }
}

// substring

// (single char - most)(different chars count == k)

// most frequent character (main char) dictionary<char, int> letter, count
// lenght of the usbstring - most frequent count = number of replacable characters

// if replacable count > k
// then currently substring maxed out

// reduce the [LEFT] letters count 
// Update the most frequent char, if updated count is less than mostfrequent
// move left pointer up

// repeat until replaceableCount <= k
