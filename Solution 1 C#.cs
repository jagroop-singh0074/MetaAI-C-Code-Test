public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result = "";
        int minLen = Math.Min(word1.Length, word2.Length);
        for (int i = 0; i < minLen; i++) {
            result += word1[i] + word2[i];
        }
        result += word1.Substring(minLen) + word2.Substring(minLen);
        return result;
    }
}