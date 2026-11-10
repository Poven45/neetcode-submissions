from collections import Counter
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        myNums = Counter(nums)
        return [num for num, count in myNums.most_common(k)]
        