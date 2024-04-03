var exist = function (board, word) {

    let visited = [];
    let index = 0;

    for (let i = 0; i < board.length; i++) {
        let row = [];

        for (let j = 0; j < board[0].length; j++) {
            row.push(false);
        }

        visited.push(row);
    }

    for (let i = 0; i < board.length; i++) {
        for (let j = 0; j < board[0].length; j++) {
            let result = backtrack(board, visited, i, j, word, index);

            if (result) {
                return true;
            }
        }
    }

    return false;
};

function backtrack(board, visited, i, j, w, index) {

    if (index >= w.length) {
        return true;
    }

    else if (i < 0 || j < 0 || i == board.length || j == board[i].length) {
        return false;
    }

    if (visited[i][j] || board[i][j] != w.charAt(index)) {
        return false;
    }

    visited[i][j] = true;

    let exists = backtrack(board, visited, i - 1, j, w, index + 1)
        || backtrack(board, visited, i, j - 1, w, index + 1)
        || backtrack(board, visited, i + 1, j, w, index + 1)
        || backtrack(board, visited, i, j + 1, w, index + 1);

    if (exists) {
        return true;
    }

    visited[i][j] = false;

    return false;
}