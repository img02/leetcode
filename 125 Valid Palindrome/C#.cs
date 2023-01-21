public class Solution {
    public bool IsPalindrome(string s) {
       s = s.ToLower();
       var l = 0;
       var r = s.Length-1;
    
       while (l < r)
       {
           if (!char.IsLetterOrDigit(s[l]))
           {
               l++;
               continue;
           }
           if (!char.IsLetterOrDigit(s[r]))
           {
               r--;
               continue;
           }

           if (s[l] != s[r]) return false;

           l++;
           r--;
       }

       return true;
    }
}