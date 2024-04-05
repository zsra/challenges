class Solution {

  public List<List<String>> groupAnagrams(String[] strs) {
    Map<String, List<String>> map = new HashMap<>();
    for (int i = 0; i < strs.length; i++) {
      char[] temp = strs[i].toCharArray();
      Arrays.sort(temp);
      String key = String.valueOf(temp);

      if (map.containsKey(key)) {
        map.get(key).add(strs[i]);
      } else {
        List<String> val = new ArrayList<>();
        val.add(strs[i]);
        map.put(key, val);
      }
    }

    List<List<String>> result = new ArrayList<>();

    for (Map.Entry<String, List<String>> entry : map.entrySet()) {
      result.add(entry.getValue());
    }

    return result;
  }
}
