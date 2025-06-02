public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> elementsCount = new Dictionary<int, int>();
                foreach (int num in nums)
                {
                    if (elementsCount.ContainsKey(num))
                        elementsCount[num] ++;
                    else
                        elementsCount.Add(num, 1);
                }
                        
                for (int i = 0; i < elementsCount.Count; i++)
                {
                    if (elementsCount[nums[i]] > 1)
                        return true;
                    
                }
                return false;
    }
}