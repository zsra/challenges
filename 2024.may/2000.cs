public string ReversePrefix(string word, char ch)
{
    Stack<char> stack = new();
    List<char> list = new();
    bool isExist = false;

    for (int i = 0; i < word.Length; i++)
    {
        stack.Push(word[i]);

        if (word[i] == ch)
        {

            if (i + 1 >= word.Length) 
            {
                isExist = !isExist;
                break;
            }

            for (int j = i + 1; j < word.Length; j++)
            {
                list.Add(word[j]);
            }

            isExist = !isExist;
            break;
        }
    }

    if (!isExist)
    {
        return word;
    }

    StringBuilder stringBuilder = new();

    while (stack.Count > 0)
    {
        stringBuilder.Append(stack.Pop());
    }

    foreach (char c in list)
    {
        stringBuilder.Append(c);
    }

    return stringBuilder.ToString();
}