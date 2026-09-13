public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> output = new();
        Dictionary<string, List<string>> dict = new();
        foreach (var str in strs) {
            var key = GenerateKey(str);
            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }

            dict[key].Add(str);
        }

        foreach (var kvp in dict) {
            output.Add(kvp.Value);
        }

        return output;
    }

    private string GenerateKey(string input) {
        var arr = input.ToLower().ToCharArray();
        Array.Sort(arr);
        return string.Join("", arr);
    }
}
