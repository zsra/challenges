public class Solution {
    public int FindKthNumber(int n, int k) {
        int current = 1;
        k--;

        while (k > 0)
        {
            long steps = CountSteps(n, current, current + 1);
            
            if (steps <= k)
            {
                current++;
                k -= (int)steps;
            }
            else
            {
                current *= 10;
                k--;
            }
        }

        return current;
    }

    private long CountSteps(int n, long current, long next)
    {
        long steps = 0;

        while (current <= n)
        {
            steps += Math.Min(n + 1, next) - current;
            current *= 10;
            next *= 10;
        }

        return steps;
    }
}