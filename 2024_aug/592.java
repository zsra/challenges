class Solution {
    public String fractionAddition(String expression) {
        List<Long[]> fractions = new ArrayList<>();
        int i = 0;

        while (i < expression.length()) {
            boolean add = true;

            if ( i != 0 || expression.charAt(i) == '+' || expression.charAt(i) == '-' ) {
                if(i == 0 && expression.charAt(i) == '-') {
                    add = false;
                }
                else{
                    add = expression.charAt(i) == '+';
                }
                i++;
            }

            StringBuilder sb = new StringBuilder();

            while (i < expression.length() && expression.charAt(i) != '+' && expression.charAt(i) != '-') {
                sb.append(expression.charAt(i));
                i++;
            }

            String[] nums = sb.toString().split("/");
            fractions.add(new Long[]{add ? Long.parseLong(nums[0]) : -Long.parseLong(nums[0]), Long.valueOf(nums[1])});
        }

        long a = 0;
        long b = 1;

        for (Long[] fraction : fractions) {
            Long c = fraction[0], d = fraction[1];
            a = a * d + b * c;
            b = b * d;
            long gcd_ = gcd(a, b);
            a /= gcd_;
            b /= gcd_;
            if (a * b < 0) {
                a = -Math.abs(a);
                b = Math.abs(b);
            }
        }

        return a + "/" + b;
    }

    private static long gcd(long a, long b) {
        while (b != 0) {
            long t = b;
            b = a % b;
            a = t;
        }
        return a;
    }
}