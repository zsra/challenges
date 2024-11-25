class Solution {
public:
    string swap(string curr, int zero, int move) {
        string next = curr;
        next[zero] = curr[move];
        next[move] = curr[zero];
        return next;
    }

    void addMove(vector<vector<int>> &board, int i, int j, vector<int> &moves) {
        if (i < 0 || i >= board.size()) {
            return;
        }
        if (j < 0 || j >= board[i].size()) {
            return;
        }

        moves.push_back(i * board[i].size() + j);
    }

    int slidingPuzzle(vector<vector<int>> &board) {
        int m = board.size();
        int n = board[0].size();

        string start = "";
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                start += to_string(board[i][j]);
            }
        }

        string end = "";
        for (int i = 1; i < m * n; i++) {
            end += to_string(i);
        }
        end += "0";

        vector<vector<int>> allMoves;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                vector<int> moves;
                addMove(board, i - 1, j, moves);
                addMove(board, i + 1, j, moves);
                addMove(board, i, j - 1, moves);
                addMove(board, i, j + 1, moves);
                allMoves.push_back(moves);
            }
        }

        queue<string> q;
        q.push(start);

        unordered_set<string> visited;
        visited.insert(start);

        int result = 0;
        while (!q.empty()) {
            int size = q.size();
            for (int i = 0; i < size; i++) {
                string curr = q.front();
                q.pop();

                if (curr == end) {
                    return result;
                }

                int zero = curr.find('0');
                for (int move : allMoves[zero]) {
                    string next = swap(curr, zero, move);
                    if (visited.contains(next)) {
                        continue;
                    }

                    q.push(next);
                    visited.insert(next);
                }
            }

            result++;
        }

        return -1;
    }
};