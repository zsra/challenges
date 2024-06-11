public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        
        // Count the frequency of each number in arr1
        foreach (int num in arr1) {
            if (countMap.ContainsKey(num)) {
                countMap[num]++;
            } else {
                countMap[num] = 1;
            }
        }
        
        List<int> result = new List<int>();
        
        // Add the elements of arr2 in the order they appear in arr2
        foreach (int num in arr2) {
            if (countMap.ContainsKey(num)) {
                for (int i = 0; i < countMap[num]; i++) {
                    result.Add(num);
                }
                countMap.Remove(num);
            }
        }
        
        // Add the remaining elements that were not in arr2
        List<int> remaining = new List<int>();
        foreach (var entry in countMap) {
            for (int i = 0; i < entry.Value; i++) {
                remaining.Add(entry.Key);
            }
        }
        
        // Sort the remaining elements and add them to the result
        remaining.Sort();
        result.AddRange(remaining);
        
        return result.ToArray();
    }