public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head) {
        if(nums.Length == 0)
            return head;

        HashSet<int> hSet = new HashSet<int>(nums);
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode cur = dummy;
        while(cur != null && cur.next != null)
        {
            if(hSet.Contains(cur.next.val))
                cur.next = cur.next.next;
            else
                cur = cur.next;
        }

        return dummy.next;
    }
}