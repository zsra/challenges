using System;
using System.Collections.Generic;

public class Solution
{
    public int[] LeftmostBuildingQueries(int[] heights, int[][] queries)
    {
        // Store the queries for each index
        var storeQueries = new List<List<List<int>>>(heights.Length);
        for (int i = 0; i < heights.Length; i++)
        {
            storeQueries.Add(new List<List<int>>());
        }

        // Priority queue for the max index
        var maxIndex = new PriorityQueue<List<int>, int>(Comparer<int>.Create((a, b) => a - b));
        int[] result = new int[queries.Length];
        Array.Fill(result, -1);

        // Store the mappings for all queries in storeQueries
        for (int currQuery = 0; currQuery < queries.Length; currQuery++)
        {
            int a = queries[currQuery][0], b = queries[currQuery][1];
            if (a < b && heights[a] < heights[b])
            {
                result[currQuery] = b;
            }
            else if (a > b && heights[a] > heights[b])
            {
                result[currQuery] = a;
            }
            else if (a == b)
            {
                result[currQuery] = a;
            }
            else
            {
                storeQueries[Math.Max(a, b)].Add(new List<int>
                {
                    Math.Max(heights[a], heights[b]),
                    currQuery
                });
            }
        }

        // Process the priority queue
        for (int index = 0; index < heights.Length; index++)
        {
            while (maxIndex.Count > 0 && maxIndex.Peek()[0] < heights[index])
            {
                result[maxIndex.Dequeue()[1]] = index;
            }

            // Add elements from storeQueries to the priority queue
            foreach (var element in storeQueries[index])
            {
                maxIndex.Enqueue(element, element[0]);
            }
        }

        return result;
    }
}
