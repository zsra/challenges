public class Solution
{
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        StringBuilder word = new StringBuilder("");
        HashSet<string> wordSet = new HashSet<string>(dictionary);
        StringBuilder result = new StringBuilder("");
        for (int c = 0; c < sentence.Length; c++)
        {
            if (sentence[c] != ' ')
            {
                word.Append(sentence[c]);
                if (wordSet.Contains(word.ToString()))
                {
                    while (c + 1 < sentence.Length && sentence[c + 1] != ' ')
                    {
                        c++;
                    }
                }
            }
            else
            {
                if (word.Length > 0)
                {
                    result.Append(word);
                    word = new StringBuilder("");
                }
                result.Append(sentence[c]);
            }
        }
        if (word.Length > 0)
        {
            result.Append(word);
        }
        return result.ToString();
    }
}
