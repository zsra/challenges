import java.util.*;

class Solution {
    public String[] sortPeople(String[] names, int[] heights) {
        SortedMap<Integer, String> people = new TreeMap<>(Comparator.reverseOrder());

        for (int i = 0; i < names.length; i++) {
            people.put(heights[i], names[i]);
        }

        return people.values().toArray(String[]::new);
    }
}