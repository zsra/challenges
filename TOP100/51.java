class Solution {
	private List<List<String>> res;

	public List<List<String>> solveNQueens(int n) {
		res = new ArrayList<>();
		backTrack(new ArrayList<Integer>(), 0, n);
		return res;
	}

	private void backTrack(List<Integer> queenList, int row, int n) {

		if (queenList.size() == n) {
			res.add(formString(queenList));
			return;
		}
		for (int c = 0; c < n; c++) {
			if (isValidMove(row, c, queenList)) {
				queenList.add(c);
				backTrack(queenList, row + 1, n);
				queenList.remove(queenList.size() - 1);
			}
		}
	}

	private List<String> formString(List<Integer> queenList) {
		List<String> list = new ArrayList<>();
		int n = queenList.size();
		for (Integer q : queenList) {
			StringBuilder sb = new StringBuilder();
			for (int c = 0; c < n; c++) {
				if (c == q) {
					sb.append("Q");
				} else {
					sb.append(".");
				}
			}
			list.add(sb.toString());
		}
		return list;
	}

	private boolean isValidMove(int row, int col, List<Integer> queenList) {

		for (int rowTaken = 0; rowTaken < queenList.size(); rowTaken++) {

			int colTaken = queenList.get(rowTaken);

			if (col == colTaken || Math.abs(row - rowTaken) == Math.abs(col - colTaken)) {
				return false;
			}
		}

		return true;
	}
}