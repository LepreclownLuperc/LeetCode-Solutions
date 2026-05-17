public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        for (int idx = n - 1; idx >= 0; --idx) {
            if (digits[idx] == 9) {
                digits[idx] = 0;
            } else {
                digits[idx]++;
                return digits;
            }
        }
        int[] newDigits = new int[n + 1];
        newDigits[0] = 1;
        return newDigits;
    }
}