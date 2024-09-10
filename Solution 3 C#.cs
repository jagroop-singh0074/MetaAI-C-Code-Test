public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxCandies = candies.Max();
        return candies.Select(candy => candy + extraCandies >= maxCandies).ToList();
    }
}