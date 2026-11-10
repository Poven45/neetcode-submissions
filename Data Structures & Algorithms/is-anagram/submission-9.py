class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        sCounter = collections.Counter(s)
        tCounter = collections.Counter(t)

        if(sCounter == tCounter):
            return True
        return False