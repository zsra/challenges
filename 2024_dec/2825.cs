public class Solution
{
    public bool CanMakeSubsequence(string source, string target)
    {
        int targetIndex = 0;
        int targetLength = target.Length;

        foreach (char currChar in source)
        {
            if (targetIndex < targetLength 
                && (target[targetIndex] - currChar + 26) % 26 <= 1)
            {
                targetIndex++;
            }
        }

        return targetIndex == targetLength;
    }
}