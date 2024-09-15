public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }
        int totalLen = nums1.Length + nums2.Length;
        int halfLen = totalLen / 2;
        int left = 0;
        int right = nums1.Length - 1;
        while (true) {
            int i = (left + right) / 2;
            int j = halfLen - i - 2;
            double nums1Left = i >= 0 ? nums1[i] : double.NegativeInfinity;
            double nums1Right = i + 1 < nums1.Length ? nums1[i + 1] : double.PositiveInfinity;
            double nums2Left = j >= 0 ? nums2[j] : double.NegativeInfinity;
            double nums2Right = j + 1 < nums2.Length ? nums2[j + 1] : double.PositiveInfinity;
            if (nums1Left <= nums2Right && nums2Left <= nums1Right) {
                if (totalLen % 2 == 0) {
                    return (Math.Max(nums1Left, nums2Left) + Math.Min(nums1Right, nums2Right)) / 2;
                } else {
                    return Math.Min(nums1Right, nums2Right);
                }
            } else if (nums1Left > nums2Right) {
                right = i - 1;
            } else {
                left = i + 1;
            }
        }
    }
}
