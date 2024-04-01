class Solution {

  public int maxProfit(int[] prices) {
    int lowest = prices[0];
    int maxProfit = 0;
    for (int i = 1; i < prices.length; i++) {
      if (prices[i] < lowest) {
        lowest = prices[i];
        continue;
      }

      maxProfit = Math.max(maxProfit, prices[i] - lowest);
    }

    return maxProfit;
  }
}
