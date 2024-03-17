import java.math.BigInteger;

class Solution {
	public int uniquePaths(int m, int n) {
        return (int)(getFactorial(n + m - 2).divide(getFactorial(n - 1).multiply(getFactorial((n + m - 2) - (n - 1)))).longValue());
    }
    
    private BigInteger getFactorial(int value) {
    	BigInteger result = new BigInteger("1");
    	
    	for(int i = 1; i <= value; i++) {
    		result = result.multiply(new BigInteger(String.format("%s", i)));
    	}
    	
    	return result;
    }
}