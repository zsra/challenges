class MedianFinder {

  PriorityQueue<Integer> minHeap;
  PriorityQueue<Integer> maxHeap;

  public MedianFinder() {
    minHeap = new PriorityQueue<>();
    maxHeap = new PriorityQueue<>((a, b) -> b - a);
  }

  public void addNum(int num) {
    if (minHeap.isEmpty() || minHeap.peek() < num) minHeap.add(
      num
    ); else maxHeap.add(num);
    rebalance();
  }

  private void rebalance() {
    if (minHeap.size() - maxHeap.size() > 1) {
      maxHeap.add(minHeap.poll());
    } else if (maxHeap.size() - minHeap.size() > 1) {
      minHeap.add(maxHeap.poll());
    }
  }

  public double findMedian() {
    if (minHeap.size() > maxHeap.size()) return minHeap.peek(); else if (
      maxHeap.size() > minHeap.size()
    ) return maxHeap.peek(); else return (
      (minHeap.peek() + maxHeap.peek()) / 2.0
    );
  }
}
