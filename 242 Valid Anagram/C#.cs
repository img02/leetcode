using System.Collections.Immutable;
public class Solution {
    public bool IsAnagram(string s, string t) {
        
       if (s.Length != t.Length) return false;

       var alphabet = new int[26];       
       foreach(var c in s)
       {
           alphabet[c-'a']++;
       }
       
       foreach(var c in t){
           alphabet[c-'a']--;
       }

       foreach(var num in alphabet){
           if (num != 0 )
           return false;
       }
       return true;
       
        /* 
        //okayish speed
        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();

        Array.Sort(sArr);
        Array.Sort(tArr);

        Console.WriteLine(sArr);
        Console.WriteLine(tArr);

        return sArr.SequenceEqual(tArr);
       */

        
        /* 
        //slower
        var so = s.OrderBy(c => c);
        var to = t.OrderBy(c => c);

        return so.SequenceEqual(to);
        */

        //same as above ^^ 
        //return s.OrderBy(c => c).SequenceEqual(t.OrderBy(d => d));
    }
}