class Solution {
    public int findComplement(int num) {
        StringBuilder s = new StringBuilder();

        while (num > 0)
        {
            s.insert(0, ((num % 2) == 0 ? "1" : "0"));
            num = num / 2;
        }

        return Integer.parseInt(s.toString(), 2);
    }
}