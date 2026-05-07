public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var freqMap = new Dictionary<int, int>();
        var res = new List<int>();
    
        foreach (int num in nums) {
            if(freqMap.ContainsKey(num)){
                freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
            }else{
                freqMap[num] = 1;
            }            
        }

        var sortedFreq = freqMap.OrderByDescending(x => x.Value).Take(k);
        // foreach(var count in sortedFreq){
        //     res.Add(count.Key);
        // }

        return sortedFreq.Select(x => x.Key).ToArray();
    
   
    }
}
