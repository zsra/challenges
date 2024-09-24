public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        int[] memo = Enumerable.Repeat(-1, s.Length).ToArray();
        return Backtrack(0);
        
        int Backtrack(int i)
        {
            if (i == s.Length)
            {
                return 0;
            }
            
            if (memo[i] >= 0)
            {
                return memo[i];
            }
            
            int res = 1 + Backtrack(i + 1);
            
            foreach (string word in dictionary)
            {
                if (s.Length - i >= word.Length &&
                    s.Substring(i, word.Length) == word)
                {
                    res = Math.Min(res, Backtrack(i + word.Length));
                }
            }
            
            memo[i] = res;
            return res;
        }
    }
}