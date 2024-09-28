public class Solution 
{
    private struct Pair 
    {
        public readonly string s;
        public readonly int i;

        public Pair(string s, int i)
        {
            this.s = s;
            this.i = i;
        }
    }

    public int[] SumPrefixScores(string[] words) 
    {
        int n = words.Length;

        var w = new Pair[n];
        for (int i = 0; i < n; ++i)
        {
            w[i] = new Pair(words[i], i);
        }
        Array.Sort(w, (a, b) => a.s.CompareTo(b.s));

        var ans = new int[n];
        var r = new List<int> { n };
        for (int i = 0; i < n; ++i)
        {
            while (i >= r[^1])
                r.RemoveAt(r.Count - 1);

            for (int j = r.Count - 1; j < w[i].s.Length; ++j)
            {
                int cnt = 0;
                for (int k = i; k < r[j]; ++k)
                {
                    if (w[k].s[j] == w[i].s[j])
                        ++cnt;
                    else break;
                }
                r.Add(i + cnt);

                for (int k = i; k < i + cnt; ++k)
                    ans[w[k].i] += cnt;
            }
        }

        return ans;
    }
}