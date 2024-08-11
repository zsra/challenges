class Solution {
    private static final int[][] DIRECTIONS = {{0, 1}, {1, 0}, {0, -1}, {-1, 0}};
    private int rows, cols;

    public int minDays(int[][] grid) {
        rows = grid.length;
        cols = grid[0].length;

        if (isDisconnected(grid)) return 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    grid[i][j] = 0;
                    if (isDisconnected(grid)) return 1;
                    grid[i][j] = 1;
                }
            }
        }

        return 2;
    }

    private boolean isDisconnected(int[][] grid) {
        boolean[][] visited = new boolean[rows][cols];
        boolean foundLand = false;

        for (int i = 0; i < rows && !foundLand; i++) {
            for (int j = 0; j < cols && !foundLand; j++) {
                if (grid[i][j] == 1) {
                    foundLand = true;
                    dfs(grid, visited, i, j);
                }
            }
        }

        if (!foundLand) return true;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1 && !visited[i][j]) {
                    return true;
                }
            }
        }

        return false;
    }

    private void dfs(int[][] grid, boolean[][] visited, int x, int y) {
        visited[x][y] = true;
        for (int[] dir : DIRECTIONS) {
            int newX = x + dir[0];
            int newY = y + dir[1];
            if (isValid(newX, newY, grid) && grid[newX][newY] == 1 && !visited[newX][newY]) {
                dfs(grid, visited, newX, newY);
            }
        }
    }

    private boolean isValid(int x, int y, int[][] grid) {
        return x >= 0 && x < rows && y >= 0 && y < cols;
    }
