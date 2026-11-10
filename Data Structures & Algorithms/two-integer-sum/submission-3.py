class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        myNums = {}
        for num in range(len(nums)):
            needed = target - nums[num]
            if needed in myNums.keys():
                return [myNums[needed], num]
            myNums[nums[num]] = num