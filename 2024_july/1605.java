class Solution {

    long totalSumRows = 0;

    public int[][] restoreMatrix(int[] rowSum, int[] colSum) {

        int[][] result = new int[rowSum.length][colSum.length];
        int[] rowIndexes = sortArrayWithIndices(rowSum);
        int[] columnIndexes = sortArrayWithIndices(colSum);

        totalSumRows /= 2;

        int pointerRow = 0;
        int pointerCol = 0;

        while (totalSumRows > 0) {

            if (colSum[columnIndexes[pointerCol]] == 0) {
                pointerCol++;
            }

            if (rowSum[rowIndexes[pointerRow]] == 0) {
                pointerRow++;
            }

            int diff = colSum[columnIndexes[pointerCol]] - rowSum[rowIndexes[pointerRow]];
            if (diff < 0) {
                result[rowIndexes[pointerRow]][columnIndexes[pointerCol]] = colSum[columnIndexes[pointerCol]];
                rowSum[rowIndexes[pointerRow]] -= colSum[columnIndexes[pointerCol]];
                totalSumRows -= colSum[columnIndexes[pointerCol]];
                colSum[columnIndexes[pointerCol]] = 0;
            } else {
                result[rowIndexes[pointerRow]][columnIndexes[pointerCol]] = rowSum[rowIndexes[pointerRow]];
                totalSumRows -= rowSum[rowIndexes[pointerRow]];
                colSum[columnIndexes[pointerCol]] = diff;
                rowSum[rowIndexes[pointerRow]] = 0;
            }
        }

        return result;
    }

    private int[] sortArrayWithIndices(int[] array) {
        int n = array.length;
        int[][] indexedArray = new int[n][2];

        for (int i = 0; i < n; i++) {
            indexedArray[i][0] = array[i];
            indexedArray[i][1] = i;
            totalSumRows += array[i];
        }

        Arrays.sort(indexedArray, Comparator.comparingInt(a -> a[0]));

        int[] originalIndices = new int[n];
        for (int i = 0; i < n; i++) {
            originalIndices[i] = indexedArray[i][1];
        }

        return originalIndices;
    }
}