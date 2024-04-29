class Solution(object):
    def containsDuplicate(self, nums):
        s = set()
        for num in nums:
            if num in s:
                return False
            else:
                s.add(num)
    
    return True