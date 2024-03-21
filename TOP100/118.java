class Solution {

  public List<List<Integer>> generate(int numRows) {
    
    List<List<Integer>> result = new ArrayList<>();

    for (int i = 1; i <= numRows; i++) {
      List<Integer> line = new ArrayList<>();
      for (int j = 0; j < i; j++) {
        if (j == 0) {
          line.add(1);
        } else if (i == 2 || j == i - 1) {
          line.add(1);
        } else {
          List<Integer> prev = result.get(result.size() - 1);

          line.add(prev.get(j - 1) + prev.get(j));
        }
      }

      result.add(line);
    }

    return result;
  }
}
