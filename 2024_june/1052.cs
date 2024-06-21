public class Solution
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        int satisfiedCustomers = 0;
        int unsatisfiedCustomers = 0;
        int windowStart = 0;
        int maxUnsatisfiedCustomers = 0;
        int currentMinute = 0;
        while (currentMinute < customers.Length)
        {
            if (grumpy[currentMinute] == 0)
                satisfiedCustomers += customers[currentMinute];
            else
                unsatisfiedCustomers += customers[currentMinute];

            if (currentMinute - windowStart + 1 == minutes)
            {
                maxUnsatisfiedCustomers = Math.Max(maxUnsatisfiedCustomers, unsatisfiedCustomers);

                if (grumpy[windowStart] == 1)
                    unsatisfiedCustomers -= customers[windowStart];

                windowStart++;
            }
            currentMinute++;
        }

        return satisfiedCustomers + maxUnsatisfiedCustomers;
    }
}
