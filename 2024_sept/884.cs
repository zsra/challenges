public class Solution {
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var wordsMap = new Dictionary<string, int>();

        foreach(var s in (s1 + ' ' + s2).Split(' '))
        {
            wordsMap[s] = !wordsMap.ContainsKey(s) ? 1 : wordsMap[s] + 1;
        }        

        return wordsMap.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
    }
}