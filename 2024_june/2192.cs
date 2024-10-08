public class Solution
{
    public IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        List<List<int>> adjList = new();

        for (int i = 0; i < n; i++)
        {
            adjList.Add(new());
        }

        foreach (var ed in edges)
        {
            adjList[ed[1]].Add(ed[0]);
        }

        List<IList<int>> allAncestors = new();

        for (int i = 0; i < n; i++)
        {
            int[] visited = new int[n];
            var ancestorsList = Dfs(adjList, i, visited);
            ancestorsList.Sort();
            allAncestors.Add(ancestorsList);
        }

        return allAncestors;
    }

    private List<int> Dfs(List<List<int>> adjList, int node, int[] visited)
    {
        List<int> ancestors = new();

        foreach (var nd in adjList[node])
        {
            if (visited[nd] == 1)
            {
                continue;
            }

            visited[nd] = 1;

            var ancs = Dfs(adjList, nd, visited);
            ancs.Add(nd);
            ancestors.AddRange(ancs);
        }

        return ancestors;
    }
}
