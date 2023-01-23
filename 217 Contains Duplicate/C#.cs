public class Solution {
    public bool ContainsDuplicate(int[] nums) {        


        /*
        // this has to go thru the entirety of nums, so slower?
        var countHash = new HashSet<int>(nums);   
        return countHash.Count != nums.Length;     
        */
         
        // this stops as soons as nums has duplicate
        var countHash = new HashSet<int>();   

        foreach (var n in nums)
        {
            if (!countHash.Add(n)) return true;
        }

        return false;        
    }
}