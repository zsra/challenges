class Solution {
    public boolean isPalindrome(ListNode head) {
        List<Integer> numbers = new ArrayList<>();

        ListNode current = head;

        while (current != null) {
            numbers.add(current.val);
            current = current.next;
        }

        for (int i = 0; i < numbers.size() / 2; i++) {
            if (numbers.get(i).intValue()
                    != numbers.get(numbers.size() - 1 - i).intValue()) {
                return  false;
            }
        }

        return  true;
    }
}