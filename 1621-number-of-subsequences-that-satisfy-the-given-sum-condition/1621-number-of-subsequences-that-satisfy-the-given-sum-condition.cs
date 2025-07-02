public class Solution {
    public int NumSubseq(int[] nums, int target) {
        Array.Sort(nums);
        int left =0;
        int right = nums.Length-1;
        int subCount =0;
        int mod = 1000000007;

        int[] pow = new int[nums.Length];
            pow[0] =1;
        for(int i = 1; i<nums.Length; i++)
            pow[i] = (pow[i-1]*2)%mod;

        while(left<=right){
            
            if(nums[left] + nums[right] <= target){
                subCount = (subCount + pow[right - left]) %mod;
                left++;
            }
            else {
                
                right--;
            }
        }
        return subCount;
    }
}