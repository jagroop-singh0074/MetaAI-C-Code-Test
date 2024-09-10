public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];
        answer[0] = 1;
        int leftProduct = 1;
        for (int i = 1; i < n; i++) {
            leftProduct *= nums[i - 1];
            answer[i] = leftProduct;
        }
        int rightProduct = 1;
        for (int i = n - 2; i >= 0; i--) {
            rightProduct *= nums[i + 1];
            answer[i] *= rightProduct;
        }
        return answer;
    }
}