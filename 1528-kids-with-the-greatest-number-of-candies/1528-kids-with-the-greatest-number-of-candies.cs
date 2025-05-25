public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = new List<bool>();
        for (int i = 0 ; i< candies.Length ; i++){
           
            if(candies[i] + extraCandies >= candies.Max() )
                result.Add(true);
                else
                result.Add(false);
        }
        return result;
    }
}