public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        long start = 0;
        long end = (long)Math.Sqrt(c);

        while (start <= end)
        {
            long sum = start * start + end * end;

            if (sum == c)
            {
                return true;
            }

            if (sum > c)
            {
                end--;
            }
            else
            {
                start++;
            }
        }

        return false;
    }
}
