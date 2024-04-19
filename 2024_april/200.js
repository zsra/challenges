var numIslands = function(grid) {
  
    var count = 0;
    var n = grid.length;
    var m = grid[0].length;

    for (let i = 0; i < n; i++) {
        for (let j = 0; j < m; j++) {
            if (grid[i][j] == '1') {
                recursive(grid, i, j, n, m);
                count++;
            }
        }
    }

    return count;
};

function recursive(grid, i, j, n , m) {
    grid[i][j] = '2';

    if (i - 1 >= 0 && grid[i - 1][j] == '1') {
        recursive(grid, i - 1, j, n, m);
    }

    if (i + 1 < n && grid[i + 1][j] == '1') {
        recursive(grid, i + 1, j, n, m);
    }

    if (j - 1 >= 0 && grid[i][j - 1] == '1') {
        recursive(grid, i, j - 1, n, m);
    }
    
    if (j + 1 < m && grid[i][j + 1] == '1') {
        recursive(grid, i, j + 1, n, m);
    }
}