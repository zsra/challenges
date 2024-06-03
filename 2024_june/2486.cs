public class Solution {
    public int AppendCharacters(string s, string t)
    {
        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (index < t.Length && s[i] == t[index])
            {
                index++;
            }
        }
        return t.Length - index;
    }
}