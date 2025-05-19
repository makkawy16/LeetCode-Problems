public class Solution {
    public int FirstUniqChar(string s) {
        
        Dictionary<char, int> charCounts = new Dictionary<char, int>();

                foreach (char c in s)
                {
                    if (charCounts.ContainsKey(c))
                        charCounts[c]++;
                    else
                        charCounts.Add(c, 1);
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (charCounts[s[i]] == 1)
                    {
                        return i;
                    }
                }

                return -1;
        // int count = 0;
        // char[] chars = s.ToCharArray();
        // for (int i = 0; i < s.Length; i++)
        // {
        //     count = 0;
        //     for (int j = 0; j < s.Length; j++)
        //     {
        //         if (i == j)
        //             continue;
        //         if (chars[j] == chars[i])
        //             count++;

        //     }
        //     if (count == 0)
        //        return i;
        // }
        // return -1;
    }
}