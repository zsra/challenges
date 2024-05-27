public string[] FindRelativeRanks(int[] score) {
    List<int> scores = score.OrderByDescending(x => x).ToList();
    var result = new string[score.Length];

    for(int i = 0; i < scores.Count; i++)
    {
        int originalIndex = Array.IndexOf(score,scores[i]);

        if(i == 0)
        {
            result[originalIndex] = "Gold Medal";
        }
        else if(i == 1)
        {
            result[originalIndex] = "Silver Medal";
        }
        else if(i == 2)
        {
            result[originalIndex] = "Bronze Medal";
        }
        else
        {
            result[originalIndex] = (i + 1).ToString();
        }
    }

    return result;
}