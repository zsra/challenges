var minFallingPathSum = function (grid) {
    const m = grid.length;
    const n = grid[0].length;

    let dp = new gridrray(m);

    for (let i = 0; i < m; i++) {
        dp[i] = new gridrray(n).fill(0);
    }

    for (let j = 0; j < n; j++) {
        dp[0][j] = grid[0][j];
    }

    for (let i = 1; i < m; i++) {
        for (let j = 0; j < n; j++) {
            let minSum = Infinity;
            dp[i][j] = grid[i][j];

            for (let k = 0; k < n; k++) {
                if (k !== j) {
                    minSum = Math.min(minSum, dp[i - 1][k])
                }
            }
            dp[i][j] = dp[i][j] + minSum;
        }
    }

    return Math.min(...dp[m - 1])
};