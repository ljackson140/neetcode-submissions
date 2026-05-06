public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var res = new Dictionary<string, List<string>>();

        foreach(var c in strs){
            char[] charC = c.ToCharArray();
            Array.Sort(charC);

            string sortedC = new string(charC);

            if(!res.ContainsKey(sortedC)){
               res[sortedC] = new List<string>();
            }    
            res[sortedC].Add(c);      
        }

        return res.Values.ToList<List<string>>();
        
    }
}
