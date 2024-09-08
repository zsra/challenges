public class Solution {
    public ListNode[] SplitListToParts(ListNode head, int k) {
        ListNode[] res = new ListNode[k];
        int len = 0;
        ListNode temp = head;
        while (temp != null)
        {
            len++;
            temp = temp.next;
        }

        int partSize = len / k;
        int greaterParts = len % k;

        temp = head;
        for (int i = 0; i < k && temp != null; i++)
        {
            res[i] = temp;
            int currentPartSize = partSize + (i < greaterParts ? 1 : 0); 

            for (int j = 0; j < currentPartSize - 1; j++)
            {
                if (temp != null)
                {
                    temp = temp.next;
                }
            }

            if (temp != null) {
                ListNode nextPart = temp.next;
                temp.next = null;
                temp = nextPart;
            }
        }

        return res;
    }
}