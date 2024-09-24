public class Solution {
    public int StrongPasswordChecker(string password) {
        int n = password.Length;
        bool hasLower = false, hasUpper = false, hasDigit = false;
        
        for (int i = 0; i < n; i++) {
            if (char.IsLower(password[i])) hasLower = true;
            else if (char.IsUpper(password[i])) hasUpper = true;
            else if (char.IsDigit(password[i])) hasDigit = true;
        }
        
        int missingType = 3 - (hasLower ? 1 : 0) - (hasUpper ? 1 : 0) - (hasDigit ? 1 : 0);
        
        int one = 0, two = 0, replace = 0;
        for (int i = 2; i < n; i++) {
            if (password[i-2] == password[i-1] && password[i-1] == password[i]) {
                int length = 2;
                while (i+1 < n && password[i] == password[i+1]) {
                    i++;
                    length++;
                }
                if (length % 3 == 0) one++;
                else if (length % 3 == 1) two++;
                replace += length / 3;
            }
        }
        
        if (n < 6) return Math.Max(missingType, 6 - n);
        else if (n <= 20) return Math.Max(missingType, replace);
        else {
            int delete = n - 20;
            replace -= Math.Min(delete, one);
            replace -= Math.Min(Math.Max(delete - one, 0), two * 2) / 2;
            replace -= Math.Max(delete - one - 2 * two, 0) / 3;
            return delete + Math.Max(missingType, replace);
        }
    }
}
