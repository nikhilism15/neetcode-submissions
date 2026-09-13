public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        int[] answer = new int[2];
        for (int i = 0; i < nums.Length; i++){
            if (dict.ContainsKey(nums[i])) {
                answer[0] = dict[nums[i]];
                answer[1] = i;
            }
            
            dict[target - nums[i]] = i;
        }

        return answer;
    }
}
