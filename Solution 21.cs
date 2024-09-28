public class Solution {
    public IList<bool> GetResults(int[][] queries) {
        var obstacles = new List<int>();
        var results = new List<bool>();
        
        foreach (var query in queries) {
            if (query[0] == 1) {
                // Add obstacle to the list
                obstacles.Add(query[1]);
                obstacles.Sort();
            } else if (query[0] == 2) {
                // Check if block can be placed
                int x = query[1], sz = query[2];
                int idx = BinarySearch(obstacles, x);
                results.Add(idx == obstacles.Count || x - obstacles[idx-1] >= sz ? true : x >= sz);
            }
        }
        
        return results;
    }
    
    private int BinarySearch(List<int> list, int target) {
        int left = 0, right = list.Count;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (list[mid] <= target) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return left;
    }
}
