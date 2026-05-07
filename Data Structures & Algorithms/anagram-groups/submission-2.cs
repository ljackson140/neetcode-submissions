public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        //TIME TO OPTIMIZE

        var res = new Dictionary<string, List<string>>();



        foreach(var word in strs){
            var count = new int[26];

            foreach(char c in word){
                count[c - 'a']++;
            }

            //join the tuple
            var joinTuple = string.Join(',', count);
            
            if(!res.ContainsKey(joinTuple)){
               res[joinTuple] = new List<string>();
            }    
            res[joinTuple].Add(word);      
        }

        return res.Values.ToList<List<string>>();
        
    }
}
