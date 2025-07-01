public class Solution {
    public int MaxVowels(string s, int k) {
        char[] vowels = ['a','e','i','o','u'];
        int count = 0;
        int maxCount =0;

        for(int i =0; i<s.Length; i++){

             if(vowels.Contains(s[i]))
                count++;
            if(i >= k && vowels.Contains(s[i-k]))
                count--;

            maxCount = Math.Max(maxCount,count);
        }

       return maxCount;
    }
}