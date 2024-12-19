public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int topValue = 0;
        int totalChunks = 0;
        for(int i = 0; i < arr.Length - 1; i++){
            topValue = Math.Max(topValue, arr[i]);
            if(topValue == i) totalChunks++;
        }
        return totalChunks + 1;
    }
}