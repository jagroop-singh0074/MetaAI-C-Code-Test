public class Solution {
    public int MaxValue(int[] nums, int k) {
        int n = nums.Length;
        int[,] dp = new int[n + 1, k + 1];
        
        for (int i = 1; i <= n; i++) {
            int orVal = 0;
            for (int j = Math.Min(i, k); j > 0; j--) {
                orVal |= nums[i - 1];
                dp[i, j] = Math.Max(dp[i, j], dp[i - j, i - j] ^ orVal);
                for (int l = 1; l < j; l++) {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - l, i - l] ^ (orVal | nums[i - l - 1]));
                }
            }
        }
        
        return dp[n, k];
    }
}
