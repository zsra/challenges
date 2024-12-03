public class Solution {
    public string AddSpaces(string s, int[] spaces)
    {
        int spaceIndex = 0;
        var builder = new StringBuilder(s.Length + spaces.Length);

        for (int index = 0; index < s.Length; index++)
        {
            if (spaceIndex < spaces.Length && index == spaces[spaceIndex])
            {
                builder.Append(' ');
                spaceIndex++;
            }
            builder.Append(s[index]);
        }

        return builder.ToString();
    }
}