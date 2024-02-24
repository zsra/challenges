class Solution {
    public List<String> letterCombinations(String digits) {
        Dictionary<char, String> table = new Hashtable<>();
        table.put('2', "abc");
        table.put('3', "def");
        table.put('4', "ghi");
        table.put('5', "jkl");
        table.put('6', "mno");
        table.put('7', "pqrs");
        table.put('8', "tuv");
        table.put('9', "wxyz");

        ArrayList<String> combinations = new ArrayList<String>();

        if (digits.size() == 0)
        {
            return combinations;
        }

        for (char digit : digits) {
            
            ArrayList<String> temp = new ArrayList<String>();

            for (String combination : combinations) {

                for (char letter : table[digit]) {
                    temp.add(combination + letter);
                }
            }

            combinations = temp;
        }

        return combinations;
    }
}