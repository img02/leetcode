public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {        
            var answer = new Dictionary<string, IList<string>>();

            foreach (var s in strs)
            {
                /*
                 * Use a char[]
                 * 
                 * char[] hash / key will be a bunch of random ascii chars 
                 * 
                 * int[] hash / key will be 26 numbers -- can result in dupes without a delimiter
                 * where something like bdddddddddd = 01010..  = 0 1  10 0
                 *                      bbbbbbbbbbc = 01010..  = 0 10 1  0
                 *                                               a b  c d
                 * so requires some delimiter value
                 */

				// viable to just sort char array from string, uses quicksort n log n, slower
				// var hash = s.ToCharArray();
				// Array.Sort(hash);        
				
                var hash = new char[26];
                //var hash = new int[26];
                foreach (var c in s)
                {
                    hash[c - 'a']++;
                }

                var key = new String(hash);    
				// delimiter required for hash from int[], slower
                //var key = string.Join(".", hash);

                // if key doesn't exist, add key and empty list, then can add the string after -- reduces LoC
                if (!answer.ContainsKey(key))
                {
                    answer.Add(key, new List<string>());
                }               
                    answer[key].Add(s);
                
            }

            return answer.Values.ToList();
    }
}