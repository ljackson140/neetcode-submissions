public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var res = new Dictionary<string, List<string>>(); 

        foreach(var w in strs){
            var counter = new int[26];

            foreach(var c in w){
                counter[c - 'a']++;
            }

            var key = string.Join(',', counter);

            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            
            res[key].Add(w);                
            
        }

        return res.Values.ToList();
        
    }
}
