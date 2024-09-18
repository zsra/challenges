public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
         List<int> secondtime = new List<int>();

         int res = int.MaxValue;

         foreach(var t in timePoints) {

                var times = t.Split(':');
                int h = Convert.ToInt32(times[0]);
                int m = Convert.ToInt32(times[1]);
                secondtime.Add(h*60+m);
         }

         secondtime.Sort();

         for(int i=1; i< secondtime.Count; i++) {

                res = Math.Min(res,secondtime[i]-secondtime[i-1]);

         }
         return Math.Min(res,secondtime[0] + 1440 - secondtime[secondtime.Count-1]);
    }
}