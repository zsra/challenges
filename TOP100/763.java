class Solution {

  public List<Integer> partitionLabels(String s) {
    int n = s.length();
    List<Integer> l = new ArrayList<>();
    HashMap<Character, Integer> map = new HashMap<>();
    for (int i = 0; i < n; i++) map.put(s.charAt(i), i);

    int outerLoop = 0;
    while (outerLoop < n) {
      int maxEnd = map.get(s.charAt(outerLoop)), innerLoop = outerLoop + 1;
      while (innerLoop < maxEnd) {
        int curr = map.get(s.charAt(innerLoop));
        if (curr > maxEnd) {
          maxEnd = curr;
        }
        innerLoop++;
      }
      l.add(maxEnd - outerLoop + 1);
      outerLoop = maxEnd + 1;
    }

    return l;
  }
}
