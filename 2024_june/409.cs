 public int LongestPalindrome(string s)
 {
     HashSet<char> chars = new();
     int count = 0;
     for (int i = 0; i < s.Length; i++)
     {
         if(chars.Contains(s[i]))
         {
             count += 2;
             chars.Remove(s[i]);
         }
         else
         {
             chars.Add(s[i]);
         }
     }

     if (chars.Count > 0) { count++; }
     return count;
 }