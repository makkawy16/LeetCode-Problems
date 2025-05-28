public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end =  numbers.Length-1;
        while (start < end){

                if(numbers[start] + numbers[end] == target)
                    return[start+1 , end+1];
                 else if (numbers[start] + numbers[end] > target)
                    end--;
                else
                    start++;     
           
        }





        //Time Limit Exceeded
        // int length = numbers.Length;
        // for (int i = 0 ; i < length ; i++){

        //     for(int j =0 ; j<length ; j++){

        //             if(i==j)
        //             continue;

        //         if(numbers[i] + numbers[j] == target)
        //             return [i+1 , j+1];
        //     }
        // }
         return [0];
    }
}