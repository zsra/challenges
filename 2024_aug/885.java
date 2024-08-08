class Solution {
    public int[][] spiralMatrixIII(int rows, int cols, int rs, int cs) {
        int len = rows * cols;
        int count = 0;
        int[][] ans = new int[ len ][ 2 ];

        int i = rs;
        int j = cs;
        int lrs = rs;
        int lcs = cs;

        while ( count < len ) {
            if ( rs < rows ) rs++;
            if ( cs < cols ) cs++;

            if ( lrs >= 0 ) {
                i = lrs;
                if ( lcs >= 0 ) j = lcs;
                else j = 0;

                while ( j <= cs && j < cols && count < len ) {
                    ans[ count ][ 0 ] = i;
                    ans[ count ][ 1 ] = j;
                    count++;
                    j++;
                }
            }

            if ( cs < cols ) {
                i = lrs + 1;
                j = cs;

                while ( i <= rs && i < rows && count < len ) {
                    ans[ count ][ 0 ] = i;
                    ans[ count ][ 1 ] = j;
                    count++;
                    i++;
                }
            }

            if ( lrs >= 0 ) lrs--;
            if ( lcs >= 0 ) lcs--;

            if ( rs < rows ) {
                i = rs;
                j = cs - 1;

                while ( j >= lcs && j >= 0 && count < len ) {
                    ans[ count ][ 0 ] = i;
                    ans[ count ][ 1 ] = j;
                    count++;
                    j--;
                }
            }

            if ( lcs >= 0 ) {
                i = rs - 1;
                j = lcs;

                while ( i > lrs && i >= 0 && count < len ) {
                    ans[ count ][ 0 ] = i;
                    ans[ count ][ 1 ] = j;
                    count++;
                    i--;
                }
            }
        }
        return ans;
    }
}