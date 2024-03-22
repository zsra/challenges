class Solution {

  public boolean wordBreak(String s, List<String> wordDict) {
    if (s == null || s.length() == 0) return false;

    boolean[] dp = new boolean[s.length()];

    for (int i = 0; i < s.length(); i++) {
      for (int j = 0; j <= i; j++) {
        String sub = s.substring(j, i + 1);

        if (wordDict.contains(sub) && (j == 0 || dp[j - 1])) {
          dp[i] = true;
          break;
        }
      }
    }

    return dp[s.length() - 1];
  }
}
