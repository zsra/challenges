class Solution {
    public long dividePlayers(int[] skill) {

        int n = skill.length;

        Arrays.sort(skill);
        int[] chem = new int[n/2];

        int test = skill[0] + skill[n-1];
        chem[0] = skill[0] * skill[n-1];

        for(int i=1; i<n/2; i++){
            if(skill[i]+skill[n-1-i] != test){
                return -1;
            }
            else{
                chem[i] = skill[i]*skill[n-1-i];
            }
        }
        long sum =0;
        for(int i=0; i<n/2; i++){
            sum += chem[i];
        }
        return sum; 
    }
}