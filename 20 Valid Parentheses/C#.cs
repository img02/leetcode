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

// solution 2
public class Solution {
    public bool IsValid(string s) {
        var braces = new Dictionary<char,char>(){
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };

        var needed = new Stack<char>();

        foreach( var c in s){            
            if (braces.ContainsKey(c)) {
                needed.Push(braces[c]);
                continue;
            }
            if (needed.Count > 0 && needed.Peek() == c) needed.Pop();
            else return false;
        }

        return needed.Count == 0;
    }
}