public int MaximumSafenessFactor(IList<IList<int>> g) 
{
    int[][] d = new int[g.Count][];
    int[][] dp = new int[g.Count][];
    Queue<int[]> q = new Queue<int[]>();
    for (int i = 0; i < g.Count; i++)
    {
        d[i] = new int[g[i].Count];
        dp[i] = new int[g[i].Count];
        for (int j = 0; j < g[i].Count; j++)
        {
            d[i][j] = 1000;
            dp[i][j] = -1;
            if (g[i][j] == 1)
            {
                q.Enqueue(new int[] { i, j });
                d[i][j] = 0;
            }
        }
    }

    int[][] dir = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { 0, 1 },
        new int[] { -1, 0 },
        new int[] { 0, -1 }
    };

    int c = 1;
    while (q.Count != 0)
    {
        for (int i = q.Count; i > 0; i--)
        {
            int x = q.Peek()[0];
            int y = q.Peek()[1];
            for (int j = 0; j < 4; j++)
            {
                int _x = x + dir[j][0];
                int _y = y + dir[j][1];
                if (CheckBounds(_x, _y, g.Count, g[0].Count))
                {
                    if (d[_x][_y] == 1000)
                    {
                        q.Enqueue(new int[] { _x, _y });
                        d[_x][_y] = c;
                    }
                }
            }
            q.Dequeue();
        }
        c++;
    }

    PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();
    pq.Enqueue(new int[] { 0, 0, d[0][0] }, -1 * d[0][0]);
    dp[0][0] = d[0][0];
    while (pq.Count != 0)
    {
        int x = pq.Peek()[0];
        int y = pq.Peek()[1];
        int w = pq.Peek()[2];
        for (int i = 0; i < 4; i++)
        {
            int _x = x + dir[i][0];
            int _y = y + dir[i][1];
            if (CheckBounds(_x, _y, g.Count, g[0].Count))
            {
                int _w = Min(w, d[_x][_y]);
                if (dp[_x][_y] < _w)
                {
                    dp[_x][_y] = _w;
                    pq.Enqueue(new int[] { _x, _y, _w }, -1 * _w);
                }
            }
        }
        pq.Dequeue();
    }

    return dp[dp.Length - 1][dp[0].Length - 1];
}

public bool CheckBounds(int x, int y, int m, int n)
{
    return !(x == m || x == -1 || y == n || y == -1);
}

public int Min(int x, int y)
{
    return x < y ? x : y;
}