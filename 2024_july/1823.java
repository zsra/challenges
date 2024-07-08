class Solution {
    public int findTheWinner(int n, int k) {
        int sum = 0;
        for (int i = 2; i <= n; i++) {
            sum = (sum + k) % i;
        }

        return sum + 1;
    }
}