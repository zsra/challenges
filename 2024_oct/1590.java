class Solution {
    public int minSubarray(int[] nums, int p) {
        HashMap<Integer, Integer> map = new HashMap<>();
        map.put(0, -1);
        int ans = nums.length;
        int sum = 0;
        int total = 0;
        for(int num : nums){
            total = (total + num)%p;
        }

        if(total == 0) return 0;
        for(int i = 0; i<nums.length; i++){
            sum = (sum+nums[i])%p;
            int check = (sum - total + p)%p;
            if(map.containsKey(check)){
                ans = Math.min(ans, i-map.get(check));
            }
            map.put(sum, i);
        }

        return ans == nums.length? -1 : ans;
    }
}