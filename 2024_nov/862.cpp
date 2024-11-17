class Solution {
public:
    int shortestSubarray(vector<int>& nums, int k) {
        int n = nums.size();
        std::vector<std::pair<long long, int>> st(n + 1);
        long long sp = 0LL;
        int res = n + 1;

        int b = 0, e = 0;
        st[e++] = {0, -1};

        for (int i = 0; i < n; i++) {
            sp += nums[i];

            while (b < e && sp - st[b].first >= k) {
                res = std::min(res, i - st[b].second);
                b++;
            }

            while (b < e && sp <= st[e - 1].first)
                e--;
            st[e++] = {sp, i};
        }

        if (res == n + 1)
            return -1;
        return res;
    }
};