public class Solution
{
    public void SortColors(int[] nums)
    {
        int[] counts = new int[3];

        for (int i = 0; i < nums.Length; i++)
        {
            switch (nums[i])
            {
                case 0:
                    counts[0]++;
                    break;
                case 1:
                    counts[1]++;
                    break;
                default:
                    counts[2]++;
                    break;
            }
        }

        int position = 0;
        for (int i = 0; i < 3; i++)
        {
            while (counts[i] > 0)
            {
                nums[position] = i;
                position++;
                counts[i]--;
            }
        }
    }
}
