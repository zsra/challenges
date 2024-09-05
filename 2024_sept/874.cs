public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        int x = 0;
        int y = 0;
        var hs = new HashSet<(int, int)>();
        foreach (var o in obstacles) {
            hs.Add((o[0], o[1]));
        }
        int[] dirX = new int[]{0, 1, 0, -1};
        int[] dirY = new int[]{1, 0, -1, 0};
        int dir = 0;
        int max = 0;
        foreach (var c in commands) {
            if (c == -2) {
                dir = (dir + 3) % 4;
            } else if (c == -1) {
                dir = (dir + 1) % 4;
            } else {
                for (int i = 0; i < c; i++) {
                    x += dirX[dir];
                    y += dirY[dir];
                    if (hs.Contains((x, y))) {
                        x -= dirX[dir];
                        y -= dirY[dir];
                        break;
                    }
                }
                max = Math.Max(max, x * x + y * y);
            }
        }
        return max;
    }
}