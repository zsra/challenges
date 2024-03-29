class Solution {

  int m;
  int n;
  int count = 0;

  public int numIslands(char[][] grid) {
    m = grid.length;
    n = grid[0].length;

    for (int i = 0; i < m; i++) {
      check(grid, i);
    }

    return count;
  }

  public void check(char[][] grid, int i) {
    for (int j = 0; j < n; j++) {
      if (grid[i][j] == '1') {
        bfs(grid, i, j);
        count++;
      }
    }
  }

  public void bfs(char[][] grid, int i, int j) {
    grid[i][j] = '2';

    if (i - 1 >= 0 && grid[i - 1][j] == '1') bfs(grid, i - 1, j);

    if (i + 1 < m && grid[i + 1][j] == '1') bfs(grid, i + 1, j);

    if (j - 1 >= 0 && grid[i][j - 1] == '1') bfs(grid, i, j - 1);

    if (j + 1 < n && grid[i][j + 1] == '1') bfs(grid, i, j + 1);
  }
}
