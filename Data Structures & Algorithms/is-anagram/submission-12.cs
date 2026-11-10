public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> dict1 = new Dictionary<char, int>();

        foreach(char c in s){
            dict1[c] = dict1.GetValueOrDefault(c, 0) + 1;
        }
        foreach(char c in t){
            if(!dict1.ContainsKey(c) || dict1[c] == 0) return false;
            dict1[c]--;
        }
        return true;
    }
}
