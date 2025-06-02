public class Solution {
    public bool IsSubsequence(string s, string t) {

        int left = 0;
        int right = 0;

        while (left < s.Length && right < t.Length) {
            if (s[left] == t[right]) {
                left++; // increment left if only match 
            }
            right++;    // always increment right to handle order case 
        }

        return left == s.Length; // means all string is in t and in the same order

        
    }
}