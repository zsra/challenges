public ListNode DoubleIt(ListNode head)
{
    ListNode current = head = new ListNode(0, head);

    while (current.next != null)
    {
        current.val += current.next.val * 2 / 10;
        int temp = current.next.val * 2;

        if ( temp >= 10) 
        {
            current.next.val = temp - 10;
        }
        else
        {
            current.next.val = temp;
        }

        current = current.next;
    }

    return head.val == 0 ? head.next : head;
}