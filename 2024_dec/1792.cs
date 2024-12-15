public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        var sum = 0D;
        var heap = new PriorityQueue<(int pass, int total), double>();

        foreach (var c in classes)
        {
            var currentRatio = (double)c[0] / c[1];
            var nextRatio = (double)(c[0] + 1) / (c[1] + 1);

            heap.Enqueue((c[0], c[1]), currentRatio - nextRatio);

            sum = sum + currentRatio;
        }

        while (extraStudents-- > 0)
        {
            var element = heap.Dequeue();

            sum = sum - (double)element.pass / element.total;

            var pass = element.pass + 1;
            var total = element.total + 1;
            var currentRatio = (double)pass / total;
            var nextRatio = (double)(pass + 1) / (total + 1);

            heap.Enqueue((pass, total), currentRatio - nextRatio);

            sum = sum + currentRatio;
        }

        return sum / classes.Length;
    }
}