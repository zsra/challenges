public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) 
    {
        int[] prefixSum = new int[arr.Length+1];

        prefixSum[0] = 0;

        for(int i = 1; i <= arr.Length; i++)
        {
            prefixSum[i] = prefixSum[i-1] ^ arr[i-1]; 
        }

        int[] result = new int[queries.Length];

        for(int i = 0; i<queries.Length; i++)
        {
            result[i] = prefixSum[queries[i][0]] ^ prefixSum[queries[i][1]+1];
        }

        return result;
    }
}