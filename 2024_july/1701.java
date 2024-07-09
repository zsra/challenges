class Solution {

  public double averageWaitingTime(int[][] customers) {
    double waitingTime = 0;
    int startTime = 0;

    for (int i = 0; i < customers.length; ++i) {
      int arrivalTime = customers[i][0];
      int cookingTime = customers[i][1];

      startTime = Math.max(startTime, arrivalTime) + cookingTime;

      waitingTime += startTime - arrivalTime;
    }

    return waitingTime / customers.length;
  }
}
