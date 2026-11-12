public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var groups = new Dictionary<int, int>();
        foreach(int num in nums){
            groups[num] = groups.GetValueOrDefault(num, 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        var result = new List<int>();

        foreach (var pair in groups){
            if(buckets[pair.Value] == null){
                buckets[pair.Value] = new List<int>();
            }
            buckets[pair.Value].Add(pair.Key);
        }

        for(int i = buckets.Length - 1; i >= 0 && result.Count < k; i--){
            if(buckets[i] != null){
                foreach (int num in buckets[i]){
                    if (result.Count < k){
                        result.Add(num);
                    }
                }
            }
        }
        return result.ToArray();
    }
}
