public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var str in strs){
            sb.Append(str.Length).Append('#').Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        var count = 0;

        while(count != s.Length){
            int j = s.IndexOf('#', count);
            int len = int.Parse(s.Substring(count, j - count));
            result.Add(s.Substring(j + 1, len));
            count = j + 1 + len;
        }
        return result;
   }
}
