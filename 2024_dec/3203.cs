public class Solution {
    int maxDiameter = 0;

    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2)
    {
        List<int>[] adj1 = CreateAdjList(edges1);
        List<int>[] adj2 = CreateAdjList(edges2);

        FindMaxDepth(adj1, 0, new HashSet<int>());
        var d1MaxDiameter = maxDiameter;

        maxDiameter = 0;
        FindMaxDepth(adj2, 0, new HashSet<int>());
        var d2MaxDiameter = maxDiameter;

        var res = Math.Max(
            Math.Max(d1MaxDiameter, d2MaxDiameter),
            Math.Ceiling(d1MaxDiameter / 2.0) + Math.Ceiling(d2MaxDiameter / 2.0) + 1
        );

        return (int)res;
    }

    private List<int>[] CreateAdjList(int[][] edges)
    {
        List<int>[] adjList = new List<int>[edges.Length + 1];

        for (var i = 0; i < edges.Length; i++)
        {
            if (adjList[edges[i][0]] == null)
            {
                adjList[edges[i][0]] = new List<int>();
            }
            adjList[edges[i][0]].Add(edges[i][1]);

            if (adjList[edges[i][1]] == null)
            {
                adjList[edges[i][1]] = new List<int>();
            }
            adjList[edges[i][1]].Add(edges[i][0]);
        }

        return adjList;
    }

    private int FindMaxDepth(List<int>[] adj, int currentIndex, HashSet<int> visitedNodes)
    {
        if (adj[currentIndex] == null)
        {
            return 0;
        }

        int m1 = 0;
        int m2 = 0;

        visitedNodes.Add(currentIndex);

        foreach (var node in adj[currentIndex])
        {
            if (!visitedNodes.Contains(node))
            {
                var d = 1 + FindMaxDepth(adj, node, visitedNodes);

                if (d > m2)
                {
                    m1 = m2;
                    m2 = d;
                }
                else if (d > m1)
                {
                    m1 = d;
                }
            }
        }

        maxDiameter = Math.Max(maxDiameter, m1 + m2);
        return Math.Max(m1, m2);
    }
}