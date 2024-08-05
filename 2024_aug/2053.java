class Solution {
    public String kthDistinct(String[] arr, int k) {
        Set<String> all = new HashSet<>();
        Set<String> distinct = new LinkedHashSet<>();

        for (String s : arr) {
            if (!all.add(s)) {
                distinct.remove(s);
            } else {
                all.add(s);
                distinct.add(s);
            }
        }

        if (k > distinct.size()) {
            return "";
        }

        int counter = 1;
        for (String s : distinct) {
            if (counter == k) {
                return s;
            }
            counter++;
        }

        return "";
    }
}