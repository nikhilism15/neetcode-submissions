public class Solution {
    public bool IsAnagram(string s, string t) {
        return GenerateKey(s) == GenerateKey(t);
    }

    private string GenerateKey(string input) {
        var arr = input.ToLower().ToCharArray();
        Array.Sort(arr);
        return string.Join("", arr);
    }
}
