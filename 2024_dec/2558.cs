public class Solution {
    public long PickGifts(int[] gifts, int k) {

        for(var i = 0; i < k; i++){
            int max = 0;
            int index = -1;
            for(var j = 0; j < gifts.Length; j++){

                if (gifts[j] > max){
                    max = gifts[j];
                    index= j;
                }
            }

            gifts[index] = (int)Math.Sqrt(gifts[index]);
        }

        return gifts.Aggregate(0L, (a,b) => (long)a + (long)b);
    }
}