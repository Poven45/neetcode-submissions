public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);
            if(groups.ContainsKey(sorted)){
                groups[sorted].Add(str);
            } else {
                groups[sorted] = new List<string>{str};
            }
        }
        return new List<List<string>>(groups.Values);
    }
}
