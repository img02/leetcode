public class Solution {

    public string Encode(IList<string> strs) {
        var encoded = "";

        foreach(var s in strs){
            encoded += $"{s.Length}" + "^" + s;
        }
        return encoded;
    }

    public List<string> Decode(string s) {

        //4^good5^hello
        //4^good

        var decoded = new List<string>();
        
        for(var i = 0; i < s.Length; ){
            var j = i+1;
            //find the ^ delimited
            while (s[j] != '^') j++;

            //find length of word
            var len = int.Parse(s.Substring(i, j-i));

            //find the word
            var word = s.Substring(j+1, len);
            decoded.Add(word);
            i = j + len + 1;
        }


        return decoded;

   }
}
