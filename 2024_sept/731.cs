public class MyCalendarTwo {
    public class Node
    {
        public int start, mid, end, count;
        public Node left, right;

        public Node(int s, int e, int c)
        {
            start = s;
            mid = -1;
            end = e;
            count =c;
        }
    }

    public Node root;
    public MyCalendarTwo() {
        root = new Node(0, 1000000000, 0);
    }

    public bool Book(int start, int end) {
        if(Query(start, end, root) > 1) return false;
        else
        {
            Add(start, end, root);
            return true;
        }
    }

    int Query(int start, int end, Node root)
    {
        if(root.mid != -1)
        {
            if(start >= root.mid) return Query(start, end, root.right);
            else if(end <= root.mid) return Query(start, end, root.left);
            else
            {
                return Math.Max(Query(start, root.mid, root.left),
                                Query(root.mid, end, root.right));
            }
        }
        if(start >= root.start || end <= root.end) return root.count;
        else return 0;
    }

    void Add(int start, int end, Node root)
    {
        if(root.mid != -1)
        {
            if(start >= root.mid) Add(start, end, root.right);
            else if(end <= root.mid) Add(start, end, root.left);
            else
            {
                Add(start, root.mid, root.left);
                Add(root.mid, end, root.right);
            }
            return;
        }
        if(start == root.start && end == root.end) root.count++;
        else if(start == root.start)
        {
            root.mid = end;
            root.left = new Node(start, end, root.count+1);
            root.right = new Node(end, root.end, root.count);
        }
        else if(end == root.end)
        {
            root.mid = start;
            root.left = new Node(root.start, start, root.count);
            root.right = new Node(start, end, root.count+1);
        }
        else
        {
            root.mid = start;
            root.left = new Node(root.start, root.mid, root.count);
            root.right = new Node(root.mid, root.end, root.count);
            Add(start, end, root.right);
        }
    }
}