public class Solution {
    public int[][] SpiralMatrix(int m, int n, ListNode head) {
        int[][] matrix = new int[m][];
        for (int i = 0; i < m; i++) {
            matrix[i] = new int[n];
            for (int j = 0; j < n; j++) {
                matrix[i][j] = -1;
            }
        }

        int top = 0, bottom = m - 1, left = 0, right = n - 1;
        ListNode current = head;

        while (top <= bottom && left <= right && current != null) {
            for (int i = left; i <= right && current != null; i++) {
                matrix[top][i] = current.val;
                current = current.next;
            }

            top++;

            for (int i = top; i <= bottom && current != null; i++) {
                matrix[i][right] = current.val;
                current = current.next;
            }

            right--;
            
            for (int i = right; i >= left && current != null; i--) {
                matrix[bottom][i] = current.val;
                current = current.next;
            }

            bottom--;

            for (int i = bottom; i >= top && current != null; i--) {
                matrix[i][left] = current.val;
                current = current.next;
            }

            left++;
        }

        return matrix;
    }
}