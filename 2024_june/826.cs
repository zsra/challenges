public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        Array.Sort(difficulty, profit);
        Array.Sort(worker);

        int netProfit = 0;
        int maxProfit = 0;
        int k = 0;

        foreach (int w in worker)
        {
            while (k < difficulty.Length && w >= difficulty[k])
            {
                maxProfit = Math.Max(maxProfit, profit[k]);
                k++;
            }
            netProfit += maxProfit;
        }

        return netProfit;
    }
}