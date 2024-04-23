var findMinHeightTrees = function (n, edges) {
    if (n < 2) {
        return [0];
    }
    const adj = [];

    for (let i = 0; i < n; i++) {
        adj[i] = new Set();
    }

    for (let [from, to] of edges) {
        adj[from].add(to);
        adj[to].add(from);
    }
    let leaves = [];
    adj.forEach((next, vertex) => {
        if (next.size === 1) {
            leaves.push(vertex);
        }
    });
    let totalVertexes = n;

    while (totalVertexes > 2) {
        totalVertexes -= leaves.length;
        const newLeaves = [];
        for (let leaf of leaves) {
            const next = adj[leaf].keys().next().value;
            adj[next].delete(leaf);
            if (adj[next].size === 1) {
                newLeaves.push(next);
            }
        }
        leaves = newLeaves;
    }

    return leaves;

};