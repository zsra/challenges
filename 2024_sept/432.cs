public class AllOne {
    public class DNode
    {
        public HashSet<string> list;
        public int count;
        public DNode prev;
        public DNode next;

        public DNode(int n = 0)
        {
            count = n;
            list = new();
        }
    }
    Dictionary<string, DNode> dict;
    DNode head;
    DNode tail;
    public AllOne() {
        dict = new();
        head = new DNode();
        tail = new DNode();
        head.next = tail;
        tail.prev = head;
    }
    void InsertNode(DNode cur, DNode after)
    {
        var next = cur.next;
        
        cur.next.prev = after;
        cur.next = after;
        after.prev = cur;
        after.next = next;
    }

    void RemoveNode(DNode node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    public void Inc(string key) {
        if (dict.TryGetValue(key, out var node))
        {
            node.list.Remove(key);
            if (node.next == tail || node.count + 1 != node.next.count)
            {
                var newNode = new DNode(node.count + 1);
                InsertNode(node, newNode);
            }
            node.next.list.Add(key);
            dict[key] = node.next;

            if (node.list.Count == 0)
            {
                RemoveNode(node);
            }
        }
        else
        {
            if (head.next == tail || head.next.count > 1)
            {
                var newNode = new DNode(1);
                InsertNode(head, newNode);
            }

            head.next.list.Add(key);
            dict[key] = head.next;
        }
    }
    
    public void Dec(string key) {
        if (dict.TryGetValue(key, out var node))
        {
            node.list.Remove(key);

            if (node.count > 1)
            {
                if (node.prev == head || node.prev.count != node.count - 1)
                {
                    var newNode = new DNode(node.count - 1);
                    InsertNode(node.prev, newNode);
                }
                node.prev.list.Add(key);
                dict[key] = node.prev;
            }
            else
            {
                dict.Remove(key);
            }
            if (node.list.Count == 0)
            {
                RemoveNode(node);    
            }
        }
    }
    
    public string GetMaxKey() {
        if (tail.prev == head) return "";
        return tail.prev.list.FirstOrDefault() ?? ""; 
    }
    
    public string GetMinKey() {
        if (head.next == tail) return "";
        return head.next.list.FirstOrDefault() ?? "";
    }
}
