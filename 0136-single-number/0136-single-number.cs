public class Solution {
    public int SingleNumber(int[] nums) {

        
            int x = nums[0];
            for (int i = 1; i < nums.Length; i++) {
            
                x = nums[i]^x;
            }
            return x;

        // Dictionary<int,int> numsCount = new Dictionary<int,int>();
        // foreach (int i in nums) {
        //     if(numsCount.ContainsKey(i))
        //         numsCount[i]++;
        //     else
        //         numsCount.Add(i, 1);
        // }
        // return numsCount.Where(x => x.Value == 1).FirstOrDefault().Key;
    }
}