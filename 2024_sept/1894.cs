public class Solution
{
    public int ChalkReplacer(int[] chalk, int k)
    {
        int index = 0;
        while (true)
        {
            if (index >= chalk.Length) index = 0;
            k -= chalk[index];

            if ( k < 0) 
            {
                return index;
            }

            index++;
        }
    }
}
