class Solution {
    public boolean threeConsecutiveOdds(int[] arr) {
        int counter = 0;
        int pointer = 0;

        while (pointer < arr.length) {
            if (arr[pointer] % 2 != 0) {
                if (counter == 2) {
                    return true;
                }
                counter++;
            }
            else {
                counter = 0;
            }

            pointer++;
        }

        return false;
    }
}