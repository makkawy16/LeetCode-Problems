public class Solution {
    public string ReverseVowels(string s) {
      char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
int start = 0;
int end = s.Length - 1;
char[] str = s.ToCharArray();
while (start < end)
{
    while (start < end && !vowels.Contains(str[start]))
    {
        start++;
    }

    while (start < end && !vowels.Contains(str[end]))
    {
        end--;
    }
    if (start < end)
    {
        var temp = str[start];
        str[start] = str[end];
        str[end] = temp;

        start++;
        end--;
    }


}
return new string(str);
    }
}
