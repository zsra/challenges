public class Solution
{
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (m * n != original.Length)
        {
            return [];
        }

        int[][] result = new int[m][];
        int pointer_m = 0;
        int pointer_n = 0;
        result[pointer_m] = new int[n];

        foreach (int number in original)
        {
            if (pointer_n == n)
            {
                pointer_m++;
                pointer_n = 0;
                result[pointer_m] = new int[n];
            }

            result[pointer_m][pointer_n] = number;
            pointer_n++;
        }

        return result;
    }
}