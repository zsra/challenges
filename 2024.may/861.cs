public int MatrixScore(int[][] grid) 
{
    int m = grid.Length;
    int n = grid[0].Length;
    
    for (int i = 0; i < m; i++) 
    {
        if (grid[i][0] == 0) 
        {
            for (int j = 0; j < grid[i].Length; j++) 
            {
                grid[i][j] = 1 - grid[i][j];
            }
        }
    }

    for (int j = 1; j < n; j++) 
    {
        int countOnes = 0;

        for (int i = 0; i < m; i++) 
        {
            countOnes += grid[i][j];
        }

        if (countOnes < m - countOnes) 
        {
            for (int i = 0; i < grid.Length; i++) 
            {
                grid[i][j] = 1 - grid[i][j];
            }
        }
    }
    
    int score = 0;

    foreach (var row in grid) 
    {
        int rowScore = 0;
        
        foreach (var bit in row) 
        {
            rowScore = (rowScore << 1) + bit;
        }

        score += rowScore;
    }

    return score;
}