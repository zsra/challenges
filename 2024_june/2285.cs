public class Solution
{
    public long MaximumImportance(int n, int[][] roads)
    {
        int[] vertices = new int[n];

        for (int i = 0; i < n; i++)
        {
            vertices[i] = i;
        }

        int[] connections = new int[n];

        foreach (var road in roads)
        {
            connections[road[0]]++;
            connections[road[1]]++;
        }

        Array.Sort(vertices, (a, b) => connections[a].CompareTo(connections[b]));

        long maximumImportance = 0;

        for (int i = 0; i < n; i++)
        {
            maximumImportance += (long)connections[vertices[i]] * (i + 1);
        }

        return maximumImportance;
    }
}
