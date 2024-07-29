class Solution {

    public int numTeams(int[] rating) {
        int teams = 0;

        for (int middle = 0; middle < rating.length; middle++) {
            int countSmaller = 0;
            int countBigger = 0;

            for (int smaller = middle - 1; smaller >= 0; smaller--) {
                if (rating[smaller] < rating[middle]) {
                    countSmaller++;
                }
            }

            for (int bigger = middle + 1; bigger < rating.length; bigger++) {
                if (rating[bigger] > rating[middle]) {
                    countBigger++;
                }
            }

            teams += countSmaller * countBigger;
            teams += (middle - countSmaller) * (rating.length - middle - 1 - countBigger);
        }

        return teams;
    }
}