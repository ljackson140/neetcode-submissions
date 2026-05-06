public class Solution {
    public bool hasDuplicate(int[] nums) {

        var x = new HashSet<int>(nums).Count;

        return nums.Length > x;
        
    }
}