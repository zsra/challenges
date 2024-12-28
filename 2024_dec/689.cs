public class Solution {
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        int n = nums.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        int[] pSum = new int[n];

        int[] result = new int[3];
    
        for(int i = 0; i < n; i++){
            pSum[i] = nums[i] + ((i == 0) ? 0 : pSum[i - 1]);
        }

        int sum = 0;
        for(int i = 0; i < n; i++){
            if(i < k){
                sum += nums[i];
                left[i] = sum;
            }
            else{
                sum += nums[i] - nums[i - k];
                left[i] = Math.Max(left[i - 1], sum);
            }
        }
        
        sum = 0;
        for(int i = n - 1; i >= 0; i--){
            if(i + k >= n){
                sum += nums[i];
                right[i] = sum;
            }
            else{
                sum += nums[i] - nums[i + k];
                right[i] = Math.Max(right[i + 1], sum);
            }
        }

        int lsum = 0, rsum = 0;
        int spmsa = -1, maxSum = 0;

        for(int i = k; i <= n - 2 * k; i++){
            int total = left[i - 1] + right[i + k] + pSum[i + k - 1] - pSum[i - 1];
            if(total > maxSum){
                maxSum = total;
                lsum = left[i - 1];
                rsum = right[i + k];
                spmsa = i;
            }
        }

        result[1] = spmsa;

        for(int i = k - 1; i < spmsa; i++){
            if(pSum[i] - (i - k < 0 ? 0 : pSum[i - k]) == lsum){
                result[0] = i - k + 1;
                break;
            }
        }

        for(int i = (spmsa + 2 * k) - 1; i < n; i++){
            if(pSum[i] - pSum[i - k] == rsum){
                result[2] = i - k + 1;
                break;
            }
        }

        return result;
    }
}