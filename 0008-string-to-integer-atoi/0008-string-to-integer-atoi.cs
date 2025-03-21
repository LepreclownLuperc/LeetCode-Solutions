public class Solution {
    public int MyAtoi(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        
        int i = 0, n = s.Length, sign = 1;
        long result = 0;
        while (i < n && s[i] == ' ') i++;
        if (i < n && (s[i] == '+' || s[i] == '-')) {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }
        while (i < n && char.IsDigit(s[i])) {
            result = result * 10 + (s[i] - '0');
            if (sign * result < int.MinValue) return int.MinValue;
            if (sign * result > int.MaxValue) return int.MaxValue;
            
            i++;
        }

        return (int)(sign * result);
    }
}