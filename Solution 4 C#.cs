public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        flowerbed = new int[] { 0 }.Concat(flowerbed).Concat(new int[] { 0 }).ToArray();
        for (int i = 1; i < flowerbed.Length - 1; i++) {
            if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0) {
                flowerbed[i] = 1;
                count++;
            }
        }
        return count >= n;
    }
}