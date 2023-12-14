public class Solution {
       public IList<IList<int>> ThreeSum(int[] nums)
        {	
            Array.Sort(nums); // .net uses QuickSort , n log n
            var results = new List<IList<int>>();

            for (var i = 0; i < nums.Length - 2; i++)
            {
                // if prev number is same as current, already checked
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (int left = i + 1, right = nums.Length - 1; left < right;)
                {
                    var sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        results.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        left++;
                        // if new num is same as old, skip dupe
                        while (nums[left] == nums[left - 1] && left < right) left++;
                    }
                    // if sum is > 0, decrement right to reduce num value
                    else if (sum > 0)
                    {
                        right--;
                    }
                    else // increment left to increase num
                    {
                        left++;
                    }
                }
            }
            return results;
        }
}