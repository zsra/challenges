class Solution {

  public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
    for (ListNode node = l1; node != null; node = node.next) {
      if (l2 != null) {
        node.val += l2.val;

        l2 = l2.next;

        if (l2 != null && node.next == null) {
          node.next = new ListNode();
        }
      }

      if (node.val >= 10) {
        node.val -= 10;

        if (node.next == null) {
          node.next = new ListNode();
        }
        node.next.val += 1;
      }
    }
    return l1;
  }
}
