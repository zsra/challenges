public class Solution
{
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        int n = hand.Length;
        if (n % groupSize != 0) 
        {
            return false;
        }

        SortedDictionary<int, int> map = new SortedDictionary<int, int>();
        foreach (int x in hand)
        {
            if (!map.ContainsKey(x))
            {
                map[x] = 0;
            }

            map[x]++;
        }

        while (map.Count > 0)
        {
            int first = map.Keys.First();
            for (int i = 0; i < groupSize; i++)
            {
                int current = first + i;
                if (!map.ContainsKey(current))
                {
                    return false;
                }
                if (--map[current] == 0)
                {
                    map.Remove(current);
                }
            }
        }

        return true;
    }
}
