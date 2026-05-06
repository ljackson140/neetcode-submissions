public class Solution {
    public bool hasDuplicate(int[] nums) {
        var containNums = new HashSet<int>();

        foreach(var num in nums){
            if(!containNums.Contains(num)){
                containNums.Add(num);
            } 
            else 
            {
                return true;
            }
        }
        return false;
    }
}