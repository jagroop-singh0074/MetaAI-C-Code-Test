public class Solution {
    public int[] FindLexSmallestString(string word1, string word2) {
        int n = word1.Length;
        int m = word2.Length;
        List<int>[] dp = new List<int>[m];
        for (int i = 0; i < m; i++) {
            dp[i] = new List<int>();
        }
        dp[0].Add(0);
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (word1[j] == word2[i]) {
                    if (i > 0 && dp[i - 1].Count > 0 && j > dp[i - 1][dp[i - 1].Count - 1]) {
                        dp[i].Add(j);
                    } else if (i == 0) {
                        dp[i].Add(j);
                    }
                }
            }
        }
        
        if (dp[m - 1].Count == 0) {
            return new int[0];
        }
        
        int[] res = dp[m - 1].ToArray();
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < dp[i].Count; j++) {
                if (dp[i][j] < res[i]) {
                    res[i] = dp[i][j];
                }
            }
        }
        
        return res;
    }
}
