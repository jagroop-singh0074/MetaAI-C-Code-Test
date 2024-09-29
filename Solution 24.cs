public class Solution {
    public int MaximumValueSum(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        int maxSum = int.MinValue;
        
        // Get max values for each row
        int[] rowMax = new int[m];
        for (int i = 0; i < m; i++) {
            rowMax[i] = board[i].Max();
        }
        
        // Iterate over columns
        for (int i = 0; i < n; i++) {
            for (int k = i; k < n; k++) {
                // Calculate sum for current columns
                int colSum = 0;
                HashSet<int> usedRows = new HashSet<int>();
                for (int col = i; col <= k; col++) {
                    for (int j = 0; j < m; j++) {
                        if (!usedRows.Contains(j)) {
                            colSum += board[j][col];
                            usedRows.Add(j);
                            break;
                        }
                    }
                }
                // Find remaining max value
                int remainingMax = int.MinValue;
                for (int j = 0; j < m; j++) {
                    if (!usedRows.Contains(j)) {
                        remainingMax = Math.Max(remainingMax, rowMax[j]);
                    }
                }
                maxSum = Math.Max(maxSum, colSum + remainingMax);
            }
        }
        
        return maxSum;
    }
}
