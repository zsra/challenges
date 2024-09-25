public class Solution 
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2) 
    {
        return Hashset(arr1, arr2);
    }

    int Hashset(int[] arr1, int[] arr2)
    {
        var set = new HashSet<int>();

        foreach (var num in arr1)
        {
            var cur = num;
            
            while (cur > 0)
            {
                if (!set.Add(cur))
                    break;
                
                cur /= 10;
            }
        }

        var max = 0;

        foreach (var num in arr2)
        {
            var cur = num;
            
            while (cur > 0)
            {
                if (set.Contains(cur))
                {
                    max = Math.Max(max, cur);
                }
                
                cur /= 10;
            }
        }

        if (max == 0)
            return 0;

        var length = 0;

        while (max > 0)
        {
            length++;
            max /= 10;
        }

        return length;
    }
}