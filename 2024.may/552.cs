public class Solution {
    public int CheckRecord(int n) {
        long dp0=1,dp1=1,dp2=0,dp3=1,dp4=0,dp5=0;
        for(int i=1;i<n;i++){
            long nextdp0=dp0+dp1+dp2;
            long nextdp1=dp0;
            long nextdp2=dp1;
            long nextdp3=dp0+dp1+dp2+dp3+dp4+dp5;
            long nextdp4=dp3;
            long nextdp5=dp4;
            dp0=nextdp0 % 1000000007;
            dp1=nextdp1 % 1000000007;
            dp2=nextdp2 % 1000000007;
            dp3=nextdp3 % 1000000007;
            dp4=nextdp4 % 1000000007;
            dp5=nextdp5 % 1000000007;
        }
        return (int)((dp0+dp1+dp2+dp3+dp4+dp5)%1000000007);
    }
}