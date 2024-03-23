class Solution {

  public int maxProduct(int[] nums) {
    int mpp = nums[0];
    int mnp = nums[0];
    int omax = nums[0];

    for (int i = 1; i < nums.length; i++) {
      int val = nums[i];
      if (val < 0) {
        int temp1 = mnp;
        int temp2 = mpp;
        mpp = Math.max(val, temp1 * val);
        mnp = Math.min(val, temp2 * val);
      } else {
        mpp = Math.max(val, val * mpp);
        mnp = Math.min(val, val * mnp);
      }
      omax = Math.max(mpp, omax);
    }

    return omax;
  }
}
