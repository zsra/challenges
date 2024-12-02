public class Solution
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        string[] strings = sentence.Split(' ');

        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].StartsWith(searchWord))
            {
                return i + 1;
            }
        }

        return -1;
    }
}