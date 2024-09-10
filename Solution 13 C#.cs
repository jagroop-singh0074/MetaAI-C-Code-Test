public class Solution {
    public int MaxVowels(string s, int k) {
        string vowels = "aeiou";
        int maxCount = 0;
        int count = 0;
        for (int i = 0; i < s.Length; i++) {
            if (vowels.Contains(s[i])) {
                count++;
            }
            if (i >= k && vowels.Contains(s[i - k])) {
                count--;
            }
            if (i >= k - 1) {
                maxCount = Math.Max(maxCount, count);
            }
        }
        return maxCount;
    }
}