public class Solution
{
    public int GetLucky(string s, int k)
    {
        StringBuilder numericString = new StringBuilder();
        foreach (char ch in s)
        {
            numericString.Append(ch - 'a' + 1);
        }

        string result = numericString.ToString();

        while (k-- > 0)
        {
            int digitSum = 0;
            foreach (char digit in numericString.ToString())
            {
                digitSum += digit - '0';
            }
            result = $"{digitSum}";
        }

        return int.Parse(result);
    }
}