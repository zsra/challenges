class Solution {
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        List<Integer>[] graph = new ArrayList[numCourses];
        for (int i = 0; i < numCourses; i++) graph[i] = new ArrayList<>();
        for (int[] pre : prerequisites) graph[pre[0]].add(pre[1]);
        
        boolean[] seen = new boolean[numCourses];
        boolean[] path = new boolean[numCourses];
        
        for (int i = 0; i < numCourses; i++) {
            if (hasCycle(graph, i, seen, path)) return false;
        }
        return true;
    }

    private boolean hasCycle(List<Integer>[] graph, int node, boolean[] seen, boolean[] path) {
        if (path[node]) return true;
        if (seen[node]) return false;
        
        seen[node] = true;
        path[node] = true;
        
        for (int nei : graph[node]) {
            if (hasCycle(graph, nei, seen, path)) return true;
        }
        
        path[node] = false;
        return false;
    }
}