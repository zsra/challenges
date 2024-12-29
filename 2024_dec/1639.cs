public class Solution {
    private const int MOD = 1000000007;
    public int NumWays(string[] words, string target) {
        int m = target.Length;
        int n = words[0].Length;

        var freq = new int[n, 26];

        foreach (var word in words)
        {
            for (int i = 0; i < n; i++)
            {
                freq[i, word[i] - 'a']++;
            }
        }

        var dp = new long[m + 1];
        dp[0] = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = m - 1; j >= 0; j--)
            {
                dp[j + 1] = (dp[j + 1] + dp[j] * freq[i, target[j] - 'a']) % MOD;
            }
        }

        return (int)dp[m];
    }
}