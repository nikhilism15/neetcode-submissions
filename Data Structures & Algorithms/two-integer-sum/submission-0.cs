public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i ++) {
            int diff = target - nums[i];
            if (result.ContainsKey(diff)) {
                return new int[2] {result[diff], i};
            }
            if (!result.ContainsKey(nums[i])) result.Add(nums[i], i);
        }
        return null;
    }
}
