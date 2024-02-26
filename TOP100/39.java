class Solution {
    public List<List<Integer>> combinationSum(int[] candidates, int target) {
		List<List<Integer>> result = new ArrayList<>();
		Arrays.sort(candidates);
		backtrack(result, new ArrayList<>(), candidates, target, 0);
          
		return result;
    }

	private void backtrack(List<List<Integer>> result, ArrayList<Integer> temp, int[] candidates, int remain, int start) {
		
		// reject
		if (remain < 0) return;
		// accept
		else if (remain == 0) {
			result.add(new ArrayList<>(temp));
		}
		else {
			for (int i = start; i < candidates.length; i++) {
				temp.add(candidates[i]);
				backtrack(result, temp, candidates, remain - candidates[i], i);
				temp.remove(temp.size() - 1);
			}
		}
	}
}