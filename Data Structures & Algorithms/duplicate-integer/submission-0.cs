
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> containNums = new HashSet<int>();
       
       foreach(int num in nums){
            if(!containNums.Contains(num)){
                containNums.Add(num);
            } else{
                return true;
            }    
       }    
        
        return false;
    }
}