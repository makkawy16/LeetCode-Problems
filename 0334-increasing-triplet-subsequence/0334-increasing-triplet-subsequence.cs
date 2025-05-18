public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int max1 = int.MaxValue;
        int max2 = int.MaxValue;
foreach (int i in nums)
{
    if (i <= max1)
    {
        max1 = i;
    }
    else if (i <= max2)
    {
        max2 = i;
    }
    else
    {
        return true;
    }
}
return false;
    }
}