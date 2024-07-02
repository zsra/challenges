class Solution {
    public int[] intersect(int[] nums1, int[] nums2) {
        int[] result = new int[1001];
        Map<Integer, Integer> map = new HashMap<>();

        for (int num : nums1) {
            map.put(num, map.getOrDefault(num, 0) + 1);
        }

        int pointer = 0;
        for (int num : nums2) {
            if (map.containsKey(num) && map.get(num) > 0) {
                result[pointer++] = num;
                map.put(num, map.getOrDefault(num, 0) - 1);
            }
        }

        return Arrays.copyOfRange(result, 0, pointer);
    }
}