class Solution {
    public int smallestChair(int[][] times, int targetFriend) {
        int targetStart = times[targetFriend][0];
        Arrays.sort(times, (a, b) -> a[0] - b[0]);
        
        PriorityQueue<Integer> seats = new PriorityQueue<>();
        for (int i = 0; i < times.length; ++ i) {
            seats.offer(i);
        }
        
        PriorityQueue<int[]> minHeap = new PriorityQueue<>((a, b) -> a[0] - b[0]);
        
        for (int i = 0; i < times.length; ++ i) {
            while (!minHeap.isEmpty() && minHeap.peek()[0] <= times[i][0]) { 
                seats.offer(minHeap.poll()[1]);
            }
            
            if (times[i][0] == targetStart) return seats.peek();
            
            minHeap.offer(new int[]{times[i][1], seats.poll()});
        }
        
        return seats.peek();
    }
}