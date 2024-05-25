public class Solution {
    public string _str;
    public List<string> _result;
    private TrieNode _root;
    
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        _str = s;
        _result = new();
        _root = new TrieNode();
        foreach (var word in wordDict)
        {
            AddToTrie(_root, word);
        }

        var builder = new StringBuilder();
        SplitWordsByDict(builder, 0, _root);

        return _result;
    }

    private void SplitWordsByDict(StringBuilder builder, int index, TrieNode trie)
    {
        if (index >= _str.Length)
        {
            if (trie.IsWord)
            {
                _result.Add(builder.ToString());   
            }
            return;
        }
        
        if (trie.IsWord)
        {
            builder.Append(' ');
            SplitWordsByDict(builder, index, _root);
            builder.Remove(builder.Length - 1, 1);
        }
        
        if (!trie.Childs.ContainsKey(_str[index]))
        {
            return;
        }
        
        builder.Append(_str[index]);
        SplitWordsByDict(builder, index + 1, trie.Childs[_str[index]]);
        builder.Remove(builder.Length - 1, 1);
    }
    
    private void AddToTrie(TrieNode trieNode, string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            trieNode.Childs.TryGetValue(word[i], out var child);
            child ??= new TrieNode();
            trieNode.Childs[word[i]] = child;

            trieNode = child;
        }

        trieNode.IsWord = true;
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Childs = new Dictionary<char, TrieNode>();

        public bool IsWord;
    }
}