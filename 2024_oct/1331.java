class Solution {
    public int[] arrayRankTransform(int[] nums) {
        int n=nums.length;
        Map <Integer,Integer> map=new HashMap<>();
        int rank=1;
        if (n==0){
            return nums;
        }
        int []copy=new int[n];
        for (int i=0;i<n;i++){
            copy[i]=nums[i];
        }
      
        Arrays.sort(nums);
          map.put(nums[0],rank);
        for (int i=1;i<n;i++){
            
            if (nums[i]==nums[i-1]){
               map.put(nums[i],rank);
            }
            else{
                rank++;
                map.put(nums[i],rank);  
            }
        }
        for (int i=0;i<n;i++){
            nums[i]=map.get(copy[i]);
        }
        return nums;
    }
}