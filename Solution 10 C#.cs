public class Solution {
    public void MoveZeroes(int[] nums) {
        int write = 0;
        for (int read = 0; read < nums.Length; read++) {
            if (nums[read] != 0) {
                nums[write++] = nums[read];
            }
        }
        while (write < nums.Length) {
            nums[write++] = 0;
        }
    }
}