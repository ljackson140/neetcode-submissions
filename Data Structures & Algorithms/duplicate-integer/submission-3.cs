public class Solution {
    public bool hasDuplicate(int[] nums) {

        var set = new HashSet<int>();

        foreach(var i in nums){
            if(set.Contains(i)){
                return true;
            }

            set.Add(i);
        }

        return false;
        
    }
}