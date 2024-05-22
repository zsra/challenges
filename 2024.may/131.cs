class Solution
{
    public IList<IList<string>> Partition(string s)
    {

        if (s == null || s.Length == 0) return [];

        IList<IList<string>> result = [];
        DoBacktrack(s, [], result);
        
        return result;
    }

    public void DoBacktrack(string s, IList<string> step, IList<IList<string>> result)
    {
        if (s == null || s.Length == 0)
        {
            result.Add(new List<string>(step));
            return;
        }
        for (int i = 1; i <= s.Length; i++)
        {
            string temp = s[..i];

            if (!IsPalindrome(temp))
            {
                continue;
            }

            step.Add(temp);
            DoBacktrack(s.Substring(i, s.Length - i), step, result);
            step.RemoveAt(step.Count - 1);
        }

        return;
    }

    public bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left <= right)
        {
            if (s.ElementAt(left) != s.ElementAt(right))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}