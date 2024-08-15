class Solution {

    public boolean lemonadeChange(int[] bills) {
        int fiveDollarBills = 0;
        int tenDollarBills = 0;

        for (int customerBill : bills) {
            switch (customerBill) {
                case 5 -> fiveDollarBills++;
                case 10 -> {
                    if ( fiveDollarBills > 0 ) {
                        fiveDollarBills--;
                        tenDollarBills++;
                    } else {
                        return false;
                    }
                }
                case 20 -> {
                    if ( tenDollarBills > 0 && fiveDollarBills > 0 ) {
                        fiveDollarBills--;
                        tenDollarBills--;
                    } else if ( fiveDollarBills >= 3 ) {
                        fiveDollarBills -= 3;
                    } else {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}