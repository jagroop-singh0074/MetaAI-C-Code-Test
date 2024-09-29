public class Solution {
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences) {
        const int MOD = 1000000007;
        Array.Sort(hFences);
        Array.Sort(vFences);
        
        int maxH = GetMaxGap(hFences, m);
        int maxV = GetMaxGap(vFences, n);
        
        int res = -1;
        for (int side = Math.Min(maxH, maxV); side > 0; side--) {
            if (CanFormSquare(hFences, vFences, side)) {
                res = (int)((long)side * side % MOD);
                break;
            }
        }
        
        return res;
    }
    
    private int GetMaxGap(int[] fences, int length) {
        int maxGap = 0;
        int prevFence = 1;
        foreach (int fence in fences) {
            maxGap = Math.Max(maxGap, fence - prevFence);
            prevFence = fence;
        }
        maxGap = Math.Max(maxGap, length - prevFence);
        return maxGap;
    }
    
    private bool CanFormSquare(int[] hFences, int[] vFences, int side) {
        List<(int, int)> hGaps = new List<(int, int)>();
        List<(int, int)> vGaps = new List<(int, int)>();
        
        int prevH = 1;
        foreach (int fence in hFences) {
            if (fence - prevH >= side) {
                hGaps.Add((prevH, fence));
            }
            prevH = fence;
        }
        hGaps.Add((prevH, hFences.Last() + side));
        
        int prevV = 1;
        foreach (int fence in vFences) {
            if (fence - prevV >= side) {
                vGaps.Add((prevV, fence));
            }
            prevV = fence;
        }
        vGaps.Add((prevV, vFences.Last() + side));
        
        foreach (var hGap in hGaps) {
            foreach (var vGap in vGaps) {
                if (hGap.Item2 - hGap.Item1 >= side && vGap.Item2 - vGap.Item1 >= side) {
                    return true;
                }
            }
        }
        
        return false;
    }
}
