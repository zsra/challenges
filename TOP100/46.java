class Solution {
    public List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> result = new ArrayList<>();
        permute(result, Arrays.stream(nums).boxed().toArray(Integer[]::new), 0);
        return result;
    }
    
    private static void permute(List<List<Integer>> result, Integer[] nums, int start) {
    	
    	if (start == nums.length) {
    		result.add(List.of(nums));
    	}
    	
    	for (int i = start; i < nums.length; i++) {
    		swap(nums, i, start);
    		permute(result, nums, start + 1);
    		swap(nums, i, start);
    	}
    }
    
    private static void swap(Integer[] array, int i, int j) {
        if (i != j) {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}