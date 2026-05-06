public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        //optimize with hashmap

        var dict = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            dict[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++){
            var diff = target - nums[i];
            if(dict.ContainsKey(diff) && dict[diff] != i)
            {
                return new int[]{i, dict[diff]};                
            }            
        }

        return new int[0];  

    }
}
