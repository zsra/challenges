class Solution(object):
    def isAnagram(self, s, t):
        c = dict()
        
        for letter in s:
            if letter in c:
                c[letter] += 1
            else:
                c[letter] = 1
                 
        for letter in t:
            if letter in c:
                c[letter] -= 1
                 
                if c[letter] == -1:
                    return False
            else:
                return False
        
        for remain in list(c.values()):
            if remain > 0:
                return False
        
        return True
        
    
    