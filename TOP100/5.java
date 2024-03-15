class Solution {

  int begin = 0;
  int end = 0;

  public String longestPalindrome(String s) {
    if (s == null) {
      return "";
    }
    char[] chArray = s.toCharArray();
    getPalindrome(chArray, 0);
    return s.substring(begin, end + 1);
  }

  private void getPalindrome(char[] chArray, int index) {
    int low = index, high = index, length = chArray.length;

    if (index > length) {
      return;
    }
    while (high < length - 1 && chArray[high] == chArray[high + 1]) {
      high++;
    }
    index = high;

    while (
      low - 1 >= 0 &&
      high + 1 <= length - 1 &&
      chArray[low - 1] == chArray[high + 1]
    ) {
      low--;
      high++;
    }

    if (end - begin < high - low) {
      begin = low;
      end = high;
    }

    getPalindrome(chArray, index + 1);
  }
}
