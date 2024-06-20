public class Solution {
    public int MaxDistance(int[] position, int m) {
        Array.Sort(position);
        int n = position.Length;

        int low = 1, high = position[n - 1] - position[0];
        int result = 0;

        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (CanPlaceBalls(position, m, mid)) {
                result = mid;
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }

        return result;
    }
    private bool CanPlaceBalls(int[] position, int m, int minDist) {
        int count = 1;
        int lastPos = position[0];

        for (int i = 1; i < position.Length; i++) {
            if (position[i] - lastPos >= minDist) {
                count++;
                lastPos = position[i];
                if (count == m) {
                    return true;
                }
            }
        }

        return false;
    }
}