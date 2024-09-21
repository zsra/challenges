public class Solution {
    public IList<int> LexicalOrder(int n) {
        var arr = new int[n];
        arr[0] = 1;
        for (int i = 1, num = 1; i < n; i++)
        {
            if (num * 10 <= n)
            {
                num *= 10;
                arr[i] = num;
            }
            else
            {
                if (num >= n)
                    num /= 10;
                while ((num % 10) == 9)
                    num /= 10;
                num++;
                arr[i] = num;
            }
        }
        return arr;
    }
}