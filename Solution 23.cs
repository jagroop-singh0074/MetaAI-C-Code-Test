public class Solution {
    public int MaximumValueSum(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        int maxSum = int.MinValue;
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                for (int k = i; k < n; k++) {
                    int col3 = (k == i) ? j + 1 : j;
                    for (int col2 = col3; col2 < n; col2++) {
                        if (col2 != i && col2 != k) {
                            int sumVal = board[j][i] + board[(j + 1) % m][k] + board[(j + 2) % m][col2];
                            maxSum = Math.Max(maxSum, sumVal);
                        }
                    }
                }
            }
        }
        
        return maxSum;
    }
}
