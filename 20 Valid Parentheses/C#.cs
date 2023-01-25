public class Solution {
    public bool IsValid(string s) {
        var lastOpen = new Stack<char>();
        var count = 0;

        foreach( var c in s)
        {
            switch (c) {
                case '(' :
                case '[' :
                case '{' :
                count--;
                lastOpen.Push(c);
                break;

                case ')' :                
                if (lastOpen.Count == 0 || lastOpen.Pop() != '(') return false;
                count++;
                break;
                case ']' :       
                if (lastOpen.Count == 0 || lastOpen.Pop() != '[') return false;
                count++;
                break;
                case '}' :
                if (lastOpen.Count == 0 || lastOpen.Pop() != '{') return false;
                count++;
                break;
            }
        }
        return count == 0;        
    }
}