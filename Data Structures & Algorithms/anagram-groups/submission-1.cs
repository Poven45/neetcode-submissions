public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> grouped = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            char [] chars = str.ToCharArray();
            Array.Sort(chars);
            string converted = new string(chars);
            if(grouped.ContainsKey(converted)){
                grouped[converted].Add(str);
            } else {
                grouped[converted] = new List<string>{ str };
            }
        }
        return new List<List<string>>(grouped.Values);
    }
}
