public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        if(nums.Length < 0) return new int[0];

        var res = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++){
            int prod = 1;
            for(int j = 0; j < nums.Length; j++){
                if(i != j){
                    prod *= nums[j];
                }                
            }      

            res[i] = prod;      
        }

        return res;        
    }
}
