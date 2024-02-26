class Solution {
    public List<String> letterCombinations(String digits) {
        Map<Character, String> table = new HashMap<>();
        table.put('2', "abc");
        table.put('3', "def");
        table.put('4', "ghi");
        table.put('5', "jkl");
        table.put('6', "mno");
        table.put('7', "pqrs");
        table.put('8', "tuv");
        table.put('9', "wxyz");

        List<String> combinations = new ArrayList<>();

        if (digits.length() == 0) {
            return combinations;
        }

        combinations.add("");

        for (char digit : digits.toCharArray()) {
            List<String> temp = new ArrayList<>();

            for (String combination : combinations) {
                String letters = table.get(digit);
                for (char letter : letters.toCharArray()) {
                    temp.add(combination + letter);
                }
            }

            combinations = temp;
        }

        return combinations;
    }
}