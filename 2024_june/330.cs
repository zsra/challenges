public class Solution
{
    public int MinPatches(int[] nums, int n)
    {
        long max = 0;
        long numsAdded = 0;

        foreach (int number in nums)
        {
            while (number > max + 1)
            {
                max += max + 1;
                numsAdded++;
                if (n < max)
                {
                    return (int)numsAdded;
                }
            }

            max += number;
            if (n < max)
            {
                break;
            }
        }
        while (n > max)
        {
            max += max + 1;
            numsAdded++;
        }

        return (int)numsAdded;
    }
}
