class Solution {
    public long maxPoints(int[][] points) {
        long ans = 0;
        int m = points.length;
        int n = points[0].length;
        long dp[] = new long[n]; 
        for (int  i = m - 1; i >= 0; i--) {
            for (int j = 1; j < n; j++) {
                dp[j] = Math.max(dp[j], dp[j-1]-1);
            }
            for (int j = n - 2; j >= 0; j--) {
                dp[j] = Math.max(dp[j], dp[j+1]-1);
            }
            for (int j = 0; j < n; j++) {
                dp[j] += points[i][j];
                ans = Math.max(ans, dp[j]);
            }
        }
        
        return ans;
    }
}