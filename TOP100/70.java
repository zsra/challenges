class Solution {

  public int climbStairs(int n) {
    return climbStairs(n, new HashMap<>());
  }

  private int climbStairs(int n, Map<Integer, Integer> memo) {
    if (n == 1 || n == 0) {
      return 1;
    }

    if (!memo.containsKey(n)) {
      memo.put(n, climbStairs(n - 1, memo) + climbStairs(n - 2, memo));
    }

    return memo.get(n);
  }
}
