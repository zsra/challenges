class Solution {
    public int maxDistance(List<List<Integer>> arrays) {
        int maxDistance = 0;
        int min = arrays.getFirst().getFirst();
        int max = arrays.getFirst().getLast();

        for (int i = 1; i < arrays.size(); i++) {
            int difference = Math.max(max - arrays.get(i).getFirst(), arrays.get(i).getLast() - min);
            maxDistance = Math.max(maxDistance, difference);
            min = Math.min(min, arrays.get(i).getFirst());
            max = Math.max(max, arrays.get(i).getLast());
        }

        return  maxDistance;
    }
}