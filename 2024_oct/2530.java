class Solution {
    public long maxKelements(int[] nums, int k) {
        PriorityQueue<Integer> pq = new PriorityQueue<>((a,b)->{
            return b-a;
        });
        long ans = 0;
        for(int n : nums){
            pq.add(n);
        }
        while(k > 0){
            k--;
            
            ans += pq.peek();
            pq.add((int)Math.ceil(pq.poll()/3.0));
        }
        return ans;
    }
}