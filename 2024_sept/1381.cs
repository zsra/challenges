public class CustomStack
{
    int[] stack;
    int maxSize;
    int top;
    int size;
    public CustomStack(int maxSize)
    {
        stack = new int[maxSize];
        this.maxSize = maxSize;
        top = -1;
        size = 0;
    }

    public void Push(int x)
    {
        if (size == maxSize )
        {
            return;
        }
        stack[++top] = x;
        size++;
    }

    public int Pop()
    {
        if (size == 0)
            return -1;
        size--;
        return stack[top--];
    }

    public void Increment(int k, int val)
    {
        if (top == -1) return;
        if (k > size)
        {
            for (int i = 0; i < size; i++)
                stack[i] += val;
        }
        else
        {
            for (int i = 0; i < k; i++)
                stack[i] += val;
        }
    }
}