public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var merged = new int[nums1.Length];

        for (int i = 0, n1 = 0, n2 = 0; i < merged.Length; i++)
        {
            if (n1 < m)
            {
                if (n2 >= n || nums1[n1] <= nums2[n2])
                {
                    merged[i] = nums1[n1++];
                    continue;
                }
            }

            if (nums2[n2] < nums1[n1] || nums1[n1] == 0)
            {
                merged[i] = nums2[n2++];
            }
        }

        for (int i = 0; i < merged.Length; i++)
        {a
            nums1[i] = merged[i];
        }
    }
}