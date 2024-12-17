public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        
        int[] count = new int[26];
        foreach (char c in s)
        {
            count[c - 'a']++;
        }

        var sb = new StringBuilder();

        for (int i=25; i>=0; i--)
        {
            if (count[i] == 0) continue;
            if (count[i] > 0)
            {
                int amountToTake = Math.Min(count[i], repeatLimit);
                sb.Append(new string((char)(i + 'a'), amountToTake));

                count[i] = count[i]-amountToTake;
            }

            if (count[i] > 0)
            {
                for (int j=i-1; j>=0; j--)
                {
                    if (count[j] == 0) continue; 
                    sb.Append((char)(j + 'a'));
                    count[j]--;
                    i++;
                    break;
                }
            }
        }

        return sb.ToString();
    }
}