public class Solution {

    public string Encode(IList<string> strs) {

        if(strs.Count == 0){
            return "";
        }

        string res = "";
        
        foreach(var s in strs){
            res += s.Length + "❤" + s;
        }

        return res;       
    }

    public List<string> Decode(string s) {
        
        var res = new List<string>();

        int i = 0;

        while (i < s.Length) {
            int j = i;
            while (s[j] != '❤') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            j = i + length;
            res.Add(s.Substring(i, length));
            i = j;
        }
        return res;
   }
}
