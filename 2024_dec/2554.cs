public class Solution
{
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        var allNumbers = Enumerable.Range(1, n).ToList();
        var validNumbers = allNumbers.Except(banned).ToList();

        validNumbers.Sort();

        int count = 0;
        int currentSum = 0;

        foreach (var num in validNumbers)
        {
            if (currentSum + num > maxSum)
            {
                break;
            }

            currentSum += num;
            count++;
        }

        return count;
    }
}