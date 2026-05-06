public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        //optimize with hashmap ONE PASS tis time 

        var dict = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){            
            var diff = target - nums[i];
            if(dict.ContainsKey(diff))
            {
                return new int[]{dict[diff], i};                
            }   
            dict[nums[i]] = i;         
        }

        return new int[0];  

    }
}
