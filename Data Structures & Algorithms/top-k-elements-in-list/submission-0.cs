public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (frequencies.ContainsKey(nums[i]))
            {
                frequencies[nums[i]] = frequencies[nums[i]] + 1;
            }
            else
            {
                frequencies.Add(nums[i], 1);
            }
        }

        List<KeyValuePair<int, int>> sortedFrequencies = (from item in frequencies
                                                          select item).ToList();

        sortedFrequencies.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

        return sortedFrequencies.Take(k).Select(kvp => kvp.Key).ToArray();
    }
}