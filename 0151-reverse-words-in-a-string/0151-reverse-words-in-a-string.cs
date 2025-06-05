public class Solution {
    public string ReverseWords(string s) {
        string[] arr = s.Trim().Split(" ");
StringBuilder reversedString = new StringBuilder();
for (int i = arr.Length-1; i >= 0; i--)
{
    if(arr[i] == "")
    continue;
    reversedString.Append(arr[i]);
    if (i == 0)
    break;
    reversedString.Append(" ");
}

    return reversedString.ToString();
    }
}