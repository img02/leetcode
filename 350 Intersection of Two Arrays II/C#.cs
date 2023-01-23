public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var doublesDict = new Dictionary<int, int>();
        var doubles = new List<int>();

        // count all the numbers in num1
        // add their count to dict
        for (int i = 0; i < nums1.Length; i++)
        {
            doublesDict.TryGetValue(nums1[i], out var numCount); 
            doublesDict[nums1[i]] = numCount + 1;
        }

        // check all nums2 values against the nums1 count in dict
        for (int i = 0; i < nums2.Length; i++)
        {
            // if the value doesn't exist as a key in dict
            // numCount will be 0
            doublesDict.TryGetValue(nums2[i], out var numCount); 
            if (numCount != 0)
            {
                doubles.Add(nums2[i]);
                doublesDict[nums2[i]] = numCount - 1;
            }            
        }
        return doubles.ToArray();
    }
}