public string ReversePrefix(string word, char ch)
{
        var arr = word.ToCharArray();
        var idx = word.IndexOf(ch);

        if (idx >= 0)
            Array.Reverse(arr, 0, idx + 1);

        return new string(arr);
}