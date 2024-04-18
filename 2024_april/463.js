var islandPerimeter = function(grid) {
    let count = 0;

    for (let i = 0; i < grid.length; i++) {
        for (let j = 0; j < grid[0].length; j++) {
            
            if (grid[i][j] == 1) {

                if (i == 0 || grid[i - 1][j] == 0) {
                    count++;
                }

                if (i == grid.length - 1 || grid[i + 1][j] == 0) {
                    count++;
                }

                if (j == 0 || grid[i][j - 1] == 0) {
                    count++;
                }

                if (j == grid[i].length - 1 || grid[i][j + 1] == 0) {
                    count++;
                }
                
            }
        }
    }

    return count;
};