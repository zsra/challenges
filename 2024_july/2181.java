class Solution {
    public ListNode mergeNodes(ListNode head) {
        ListNode current = head;
        mergeNonZeroNodes(current);
        current = head;
        removeZeroNodes(head);

        return head;
    }

    private static void removeZeroNodes(ListNode current) {
        ListNode prev = null;
        while (current.next != null) {
            if (current.val == 0) {
                current.val = current.next.val;
                current.next = current.next.next;
            }
            prev = current;
            current = current.next;
        }
        prev.next = null;
    }

    private static void mergeNonZeroNodes(ListNode current) {
        while (current.next != null) {
            if (current.val == 0) {
                ListNode firstNonNull = current.next;
                current = current.next.next;
                while (current.val != 0) {
                    firstNonNull.val += current.val;
                    current = current.next;
                }
                firstNonNull.next = current;
            } else {
                current = current.next;
            }
        }
    }
}