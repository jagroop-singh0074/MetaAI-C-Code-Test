public class Solution {
    public int MaxScore(int[,] grid) {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        bool[] used = new bool[101];
        int[] dp = new int[cols];
        
        for (int i = 0; i < rows; i++) {
            int[] temp = (int[])dp.Clone();
            for (int j = 0; j < cols; j++) {
                int val = grid[i, j];
                if (!used[val]) {
                    used[val] = true;
                    for (int k = 0; k < cols; k++) {
                        if (dp[k] > 0 || k == j) {
                            temp[k] = Math.Max(temp[k], dp[k] + val);
                        }
                    }
                }
            }
            used = new bool[101];
            dp = temp;
        }
        
        int max = 0;
        foreach (int val in dp) {
            max = Math.Max(max, val);
        }
        return max;
    }
}
