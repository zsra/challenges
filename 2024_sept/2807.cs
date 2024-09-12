public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if(head.next == null) return head;
        
        var current = head;

        while(current.next != null)
        {
            var node = new ListNode(GetGreatestCommonDivisor(current.val, current.next.val), current.next);
            current.next = node;
            current = node.next;
        }

        return head;
    }

    private static int GetGreatestCommonDivisor(int a, int b)
    {
        if(a == b) return a;

        var max = a > b ? a : b;
        var min = a < b ? a : b;
        var c = max % min;

        while(c != 0)
        {
            max = min;
            min = c;
            c = max % min;
        }

        return min;
    }
}