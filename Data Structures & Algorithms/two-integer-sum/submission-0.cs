public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var tsum = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            tsum[nums[i]] = i;                    
        }

       for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (tsum.ContainsKey(diff) && tsum[diff] != i) {
                return new int[]{i, tsum[diff]};
            }
        }

        return new int[0];

    }
}
