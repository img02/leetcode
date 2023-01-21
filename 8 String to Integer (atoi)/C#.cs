public class Solution {
    public int MyAtoi1(string s) {
        
        s = s.Trim();
        var numAsString = "";        
        var numStarted = false;
        var minusFound = false;
        
        foreach (var c in s)
        {          
            
           var outNum = 0;
           var valid = Int32.TryParse(c.ToString(), out outNum);
           
           if (c == '-')
           {
               minusFound = true;
               continue;
           }
           if (!valid && !numStarted)
           {
               minusFound = false;
               continue;
           }            
           if (!valid && numStarted) break;
            
           numStarted = true;            
           if (minusFound && numStarted)
           {
               numAsString += "-";
               minusFound = false;
           }            
           numAsString += outNum;
        }
        
        return Int32.Parse(numAsString);        
    }
    
     public int MyAtoi(string s) {
        s = s.Trim();
        if (s.Length == 0) return 0;
         
        var numAsString = "";        
        var startIndex = 0;
         var isNegative = false;
         var numStarted = false;
        
        if (s[0] == '-')
        {            
            startIndex = 1;
            numAsString += "-";
            isNegative = true;
        }
         else if (s[0] == '+') startIndex = 1;         
        else if (!Int32.TryParse(s[0].ToString(), out _)) return 0;
        
    
       for (int i = startIndex; i < s.Length; i++)
       {
           
            var outNum = 0;
            var isInt = Int32.TryParse(s[i].ToString(), out outNum);
            if (!isInt && !numStarted) return 0;
            if (!isInt) break;
            numStarted = true;
            numAsString += outNum;
        }
        
         try 
         {
             return Int32.Parse(numAsString);        
         }
         catch (Exception e)
         {
             if (isNegative && numAsString.Length > 1) return Int32.MinValue;
             else if (numAsString.Length < 5) return 0;
             else return Int32.MaxValue;
         }
        
    }
}