class Solution {
  public String longestPalindrome(String s) {
    int n = s.length();
    String res = null;

    boolean[][] table = new bolean[n][n];

     for (int i = n - 1; i >= 0; i--) {
        for (int j= i; j < n; j++) {
            table[i][j] = s.charAt(i) == s.charAt(j) &&  (j - i < 3 || table[i + 1][j - 1]);

            if ( table[i][j]  && (res == null || j - i + 1 > res.length())) {
                res = s.substring(i, j + 1);
            }
        }
     }

     return res;
  }
}
