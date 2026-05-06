public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }
    
        var stringS = new Dictionary<char, int>();
        var stringT = new Dictionary<char, int>();

        foreach(char i in s){
           stringS[i] = stringS.GetValueOrDefault(i, 0) + 1;
           //stringT[i] = stringT.GetValueOrDefault(i, 0) + 1;
        }

        foreach(char i in t){
           //stringS[i] = stringS.GetValueOrDefault(i, 0) + 1;
           stringT[i] = stringT.GetValueOrDefault(i, 0) + 1;
        }

        return stringS.Count == stringT.Count && 
        !stringS.Except(stringT).Any();       

    }
}
