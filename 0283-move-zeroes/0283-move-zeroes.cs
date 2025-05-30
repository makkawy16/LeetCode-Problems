public class Solution {
    public void MoveZeroes(int[] nums) {
        int start = 0;
        int end = 1;

        while (start < nums.Length && end<nums.Length)
        {
            if (nums[start] == 0 && nums[end] != 0)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end++;
            }
            else
            {
                if(nums[start] != 0)
                     start++;
                end++;
            }
            
        }
    }
}