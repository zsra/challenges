public class Solution {
  public int[] MissingRolls(int[] rolls, int mean, int n) {
    int sumM = rolls.Sum();
    int sumN = 0;
    int totalLength = rolls.Length + n;

    sumN = (totalLength * mean) - sumM;
    if (((decimal) sumN / n) > 6 || (sumN / n) < 1)
      return new int[] {};

    int[] nArr = new int[n];
    int nLength = n;

    for (int i = 0; i < n; i++) {
      nArr[i] = (int) sumN / nLength;
      sumN -= nArr[i];
      nLength -= 1;
    }

    return nArr;
  }
}