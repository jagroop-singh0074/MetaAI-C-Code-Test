public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }
        int rev = 0;
        int orig = x;
        while (x != 0) {
            rev = rev * 10 + x % 10;
            x /= 10;
        }
        return orig == rev;
    }
}
