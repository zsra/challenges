public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        DoBacktrack(result, [], nums, 0);

        return result;
    }

    private void DoBacktrack(IList<IList<int>> result, List<int> temp, int[] nums, int start)
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