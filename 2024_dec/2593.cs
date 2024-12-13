public class Solution {
    public long FindScore(int[] nums) {
        var marks = new int[nums.Length];
            long result = 0;
            var arrDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                arrDict.Add(i, nums[i]);
            }
            var sortedDict = arrDict.OrderBy(kvp => kvp.Value).ToDictionary(x=>x.Key, x=> x.Value);
            foreach (var kvp in sortedDict)
            {
                if (marks[kvp.Key] == 0 )
                {
                    result += kvp.Value;
                    marks[kvp.Key] = 1;
                    if (kvp.Key - 1 >= 0)
                    {
                        marks[kvp.Key - 1] = 1;
                    }
                    if (kvp.Key + 1 < nums.Length)
                    {
                        marks[kvp.Key + 1] = 1;
                    }
                }
            }
            return result;
    }
}