class Solution {

  public int orangesRotting(int[][] grid) {
    int rows = grid.length;
    int cols = grid[0].length;
    Queue<int[]> q = new LinkedList<>();
    int fresh = 0;

    for (int i = 0; i < rows; i++) {
      for (int j = 0; j < cols; j++) {
        if (grid[i][j] == 1) {
          fresh++;
        } else if (grid[i][j] == 2) {
          q.offer(new int[] { i, j });
        }
      }
    }

    int dx[] = { -1, 0, 0, 1 };
    int dy[] = { 0, 1, -1, 0 };

    int mins = 0;

    while (!q.isEmpty() && fresh > 0) {
      int size = q.size();

      while (size-- > 0) {
        int curr[] = q.poll();
        for (int i = 0; i < 4; i++) {
          int x = curr[0] + dx[i];
          int y = curr[1] + dy[i];

          if (
            x < 0 || x >= rows || y < 0 || y >= cols || grid[x][y] != 1
          ) continue;
          q.offer(new int[] { x, y });
          grid[x][y] = 2;
          fresh--;
        }
      }
      mins++;
    }
    return fresh == 0 ? mins : -1;
  }
}
