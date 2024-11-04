class Solution {
public:
    string compressedString(string word) {
        string ans;
        int idx = 0;
        while (idx < word.size()) {
            int j = idx + 1;
            while (j < word.size() && j < idx + 9) {
                if (word[j] != word[idx]) {
                    break;
                }
                ++j;
            }
            int len = j - idx;
            ans.push_back('0' + len);
            ans.push_back(word[idx]);
            idx = j;
        }
        return ans;
    }
};