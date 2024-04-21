var validPath = function(n, edges, source, destination) {
    
    if (edges.length == 0) {
        return true;
    }

    let queue = [];
    let visited = [];

    queue.push(source);
    visited[source] = true;

    while (queue.length > 0) {

        let currentNode = queue.shift();

        for (let edge of edges) {

            if (edge[0] == currentNode) {
                
                if (edge[1] == destination) {
                    return true;
                }

                if (!visited[edge[1]]) {
                    visited[edge[1]] = true;
                    queue.push(edge[1]);
                }
            }
            else if (edge[1] == currentNode) {
                
                if (edge[0] == destination) {
                    return true;
                }

                if (!visited[edge[0]]) {
                    visited[edge[0]] = true;
                    queue.push(edge[0]);
                }
            }
        }
    }

    return false;
};