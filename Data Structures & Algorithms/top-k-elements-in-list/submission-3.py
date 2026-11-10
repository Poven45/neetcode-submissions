from collections import Counter
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        if len(nums) <= 1:
            return nums
        myNums = Counter(nums)
        myList = [num for num, count in myNums.most_common(k)]
        return myList