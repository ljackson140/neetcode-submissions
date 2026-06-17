public class Solution {
    public bool hasDuplicate(int[] nums) {

        var set = new HashSet<int>();

        foreach(var n in nums){
            if(!set.Contains(n)){
                set.Add(n);
            }else{
                return true;
            }
        }

        return false;
        
    }
}