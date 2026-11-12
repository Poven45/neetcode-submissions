public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        foreach(int num in nums){
            count[num] = count.GetValueOrDefault(num, 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var pair in count){
            if(buckets[pair.Value] == null){
                buckets[pair.Value] = new List<int>();
            }
            buckets[pair.Value].Add(pair.Key);
        }

        var result = new List<int>();

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--){
            if (buckets[i] != null){
                result.AddRange(buckets[i]);
            }
        }
        return result.ToArray();
    }
}
