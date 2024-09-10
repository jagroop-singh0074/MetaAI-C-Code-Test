public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int maxLength = 0;
        int zeros = 0;
        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == 0) {
                zeros++;
            }
            while (zeros > k) {
                if (nums[left] == 0) {
                    zeros--;
                }
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}