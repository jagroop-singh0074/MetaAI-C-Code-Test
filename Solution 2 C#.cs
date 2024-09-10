public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int gcd = GCD(str1.Length, str2.Length);
        string x = str1.Substring(0, gcd);
        if (str1 == string.Concat(Enumerable.Repeat(x, str1.Length / gcd)) &&
            str2 == string.Concat(Enumerable.Repeat(x, str2.Length / gcd))) {
            return x;
        }
        return "";
    }

    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}