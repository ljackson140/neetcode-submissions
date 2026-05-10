public class Solution {

    public string Encode(IList<string> strs) {

        if(strs.Count == 0){
            return "";
        }

        string res = "";
        
        foreach(var s in strs){
            res += s.Length + "#" + s;
        }

        return res;       
    }

    public List<string> Decode(string s) {
        
        var res = new List<string>();

        int i = 0;

        while (i < s.Length) {
            // Find the delimiter '#'
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            
            // Parse the length
            int length = int.Parse(s.Substring(i, j - i));
            
            // Extract the string using the length
            var str = s.Substring(j + 1, length);
            res.Add(str);
            
            // Move pointer to the start of next chunk
            i = j + 1 + length;
        }
        
        return res;
   }
}
