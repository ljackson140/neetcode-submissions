public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var freqMap = new Dictionary<int, int>();
            
        foreach (int num in nums) {
            if(freqMap.ContainsKey(num)){
                freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
            }else{
                freqMap[num] = 1;
            }            
        }

        var sortedFreq = freqMap.OrderByDescending(x => x.Value).Take(k);

        return sortedFreq.Select(x => x.Key).ToArray();
    
   
    }
}
