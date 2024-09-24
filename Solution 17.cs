public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        int MOD = (int)1e9 + 7;
        for (int i = 0; i < k; i++) {
            int minVal = nums.Min();
            int minIdx = Array.IndexOf(nums, minVal);
            nums[minIdx] = (int)((long)minVal * multiplier % MOD);
        }
        return nums.Select(x => x % MOD).ToArray();
    }
}
