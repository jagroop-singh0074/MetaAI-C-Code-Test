public class Solution {
    public int Compress(char[] chars) {
        int anchor = 0, write = 0;
        for (int read = 0; read < chars.Length; read++) {
            if (read + 1 == chars.Length || chars[read + 1] != chars[read]) {
                chars[write++] = chars[anchor];
                if (read > anchor) {
                    foreach (char digit in (read - anchor + 1).ToString()) {
                        chars[write++] = digit;
                    }
                }
                anchor = read + 1;
            }
        }
        return write;
    }
}