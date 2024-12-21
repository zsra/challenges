public class Solution {
    
    private long DFS(Dictionary<int, List<int>> graph, int[] values, int i, ref int ans, int k, int parent = -1) {
        long sum = values[i];
        foreach(var node in graph[i]) {
            if(parent != node) {
                sum += DFS(graph, values, node, ref ans, k, i);
            }
        }
        sum %= k;
        if(sum == 0)
            ans++;
        return sum;
    }

    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k) {
        int ans = 0;
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        for(int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        
        foreach(var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        DFS(graph, values, 0, ref ans, k);

        return ans;
    }
}