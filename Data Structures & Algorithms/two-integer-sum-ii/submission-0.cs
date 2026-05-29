public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        //we want to add 2 numbers together that equals the target, if it doesnt move the left or right pointer

        //

        int l = 0, r = numbers.Length - 1;

        while (l < r) {
            int curSum = numbers[l] + numbers[r];

            if (curSum > target) {
                r--;
            } else if (curSum < target) {
                l++;
            } else {
                return new int[] { l + 1, r + 1 };
            }
        }
        return new int[0];
        
    }
}
