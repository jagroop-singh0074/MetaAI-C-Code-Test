public class Solution {
    public string ReverseVowels(string s) {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] sArray = s.ToCharArray();
        int left = 0, right = sArray.Length - 1;
        while (left < right) {
            if (!vowels.Contains(sArray[left])) {
                left++;
            } else if (!vowels.Contains(sArray[right])) {
                right--;
            } else {
                char temp = sArray[left];
                sArray[left] = sArray[right];
                sArray[right] = temp;
                left++;
                right--;
            }
        }
        return new string(sArray);
    }
}