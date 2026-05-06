public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
    
        var stringS = new Dictionary<char, int>();
        var stringT = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){
           stringS[s[i]] = stringS.GetValueOrDefault(s[i], 0) + 1;
           stringT[t[i]] = stringT.GetValueOrDefault(t[i], 0) + 1;
        }

        return stringS.Count == stringT.Count && 
        !stringS.Except(stringT).Any();       

    }
}
