class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        numsCheck = dict()
        for num in nums:
            if num in numsCheck:
                return True
            else:
                numsCheck[num] = 1
        return False