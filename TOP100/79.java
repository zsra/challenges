class Solution {
    public boolean exist(char[][] board, String word) {
        char[] w = word.toCharArray();
        for (int i = 0; i < board.length; i++) {
            for (int j = 0; j < board[i].length; j++) {     
                if (exist(board, i ,j, w, 0)) {
                    return true;
                }   
            }
        }
        
        return false;
    }
    
    private boolean exist(char[][] board, int i, int j, char[] w, int k) {
        if (k == w.length) {
            return true;
        }
        else if (i < 0 || j < 0 || i == board.length || j == board[i].length) {
            return false;
        }
        
        if (board[i][j] != w[k]) {
            return false;
        }
        
        board[i][j] ^= 256;
        
        boolean exist = exist(board, i, j+1, w, k+1)
            || exist(board, i, j-1, w, k+1)
            || exist(board, i+1, j, w, k+1)
            || exist(board, i-1, j, w, k+1);
        
        board[i][j] ^= 256;
        
        return exist;
    }
}