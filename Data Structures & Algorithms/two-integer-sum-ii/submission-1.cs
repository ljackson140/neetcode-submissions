public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        //we want to add 2 numbers together that equals the target, if it doesnt move the left or right pointer

        int left = 0;
        int right = numbers.Length - 1;

        while(left < right){
            var sum = numbers[left] + numbers[right];

            if(sum == target && left != right){
                return new int[] {left + 1, right + 1};
            } else if(sum > target){
                right--;
            } else{
                left++;
            }
        }

        return new int[0];
        
    }
}
