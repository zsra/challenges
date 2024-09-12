public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {

        var allowedSet = new HashSet<char>(allowed);
        int consistentCount = 0;

        foreach (var word in words) {
            bool isConsistent = true;

            foreach (var c in word) {
                if (!allowedSet.Contains(c)) {
                    isConsistent = false;
                    break;
                }
            }

            if (isConsistent) {
                consistentCount++;
            }
        }

        return consistentCount;
    }
}