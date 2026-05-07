public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        //Count frequencies
        var count = new Dictionary<int, int>();

        foreach (int num in nums) {            
            count[num] = count.GetValueOrDefault(num, 0) + 1;                       
        }
        
        //create buckets
        var freq = new List<int>[nums.Length + 1];

        for(int i = 0; i < freq.Length; i++){
            freq[i] = new List<int>();
        }

        //populate buckets 
        foreach(var buc in count){
            freq[buc.Value].Add(buc.Key);
        }

        //loop through buckets from largest to 1 and add it to our result 
        var res = new int[k];
        var index = 0;

        for(int i = freq.Length - 1; i > 0 && index < k; i--){
            foreach(int num in freq[i]){
                res[index++] = num;
                if(index == k){
                    return res;
                }

            }
        }

        return res;       
    
    }
}
