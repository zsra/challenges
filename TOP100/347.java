class Solution {

  public int[] topKFrequent(int[] nums, int k) {
    Map<Integer, Integer> freq = new HashMap<>();

    for (int num : nums) {
      freq.put(num, freq.getOrDefault(num, 0) + 1);
    }

    Map<Integer, Integer> sortedMap = new LinkedHashMap<>();

    freq
      .entrySet()
      .stream()
      .sorted((e1, e2) -> e2.getValue().compareTo(e1.getValue()))
      .forEachOrdered(entry -> sortedMap.put(entry.getKey(), entry.getValue()));

    int[] result = new int[k];
    int pointer = 0;

    for (Map.Entry<Integer, Integer> values : sortedMap.entrySet()) {
      if (k == 0) {
        break;
      }
      result[pointer++] = values.getKey();
      k--;
    }

    return result;
  }
}
