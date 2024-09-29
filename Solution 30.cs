public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanDict = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        int total = 0;
        for (int i = 0; i < s.Length - 1; i++) {
            if (romanDict[s[i]] < romanDict[s[i + 1]]) {
                total -= romanDict[s[i]];
            } else {
                total += romanDict[s[i]];
            }
        }
        
        total += romanDict[s[s.Length - 1]];
        return total;
    }
}
