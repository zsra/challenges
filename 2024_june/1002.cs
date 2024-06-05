public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        StringBuilder stringBuilder = new();
        for (int i = 1; i < words.Length; i++)
        {
            List<char> temp_pattern = new(words[0]);

            for (int j = 0; j < words[i].Length; j++)
            {
                if (temp_pattern.Contains(words[i][j]))
                {
                    temp_pattern.Remove(words[i][j]);
                    stringBuilder.Append(words[i][j]);
                }
            }

            if (stringBuilder.Length < words[0].Length)
            {
                words[0] = stringBuilder.ToString();
            }

            stringBuilder.Clear();
        }

        return words[0].Select(s => s.ToString()).ToList();
    }
}
