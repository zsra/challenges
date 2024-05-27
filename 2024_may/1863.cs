public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        List<List<int>> result = new();
        DoBacktrack(result, [], nums, 0);

        int sum = 0;

        foreach (List<int> list in result)
        {
            if (list.Count == 0)
            {
                continue;
            }

            int xor = list.First();
            for (int i = 1; i < list.Count; i++)
            {
                xor ^= list[i];
            }

            sum += xor;
        }

        return sum;
    }

    private void DoBacktrack(List<List<int>> result, List<int> temp, int[] nums, int start)
    {
        result.Add(new List<int>(temp));

        for (int i = start; i < nums.Length; i++)
        {
            temp.Add(nums[i]);
            DoBacktrack(result, temp, nums, i + 1);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}
