class Solution {
    public int countSeniors(String[] details) {
        int count = 0;
        for (String detail : details) {
          if (Integer.parseInt(detail.substring(11,detail.length() - 2)) > 60) {
              count++;
          }
        }

        return  count;
    }
}