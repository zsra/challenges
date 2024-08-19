class Solution {
    public int minSteps(int n) {
        int divisor = 2;
        int result = 0;

        while (n > 1) {
            while (n % divisor == 0) {
                result += divisor;
                n /= divisor;
            }
            divisor++;
        }

        return result;
    }
}