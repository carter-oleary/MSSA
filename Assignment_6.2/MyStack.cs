using System.Text;

public class MyStack<T>
{
    private T[] Stack;

    public MyStack(T[] stack)
    {
        Stack = stack.Reverse().ToArray();
    }

    public void Push(T i)
    {
        T[] temp = Stack;
        Array.Resize(ref temp, Stack.Length + 1);
        Stack = temp;
        Stack[Stack.Length - 1] = i;
    }

    public T Pop()
    {
        T popped = Stack[Stack.Length - 1];
        Stack = Stack.Take(Stack.Length - 1).ToArray();
        return popped;
    }

    public T Peek()
    {
        return Stack[Stack.Length - 1]; 
    }

    public string ToString()
    {
        if (Stack.Length == 0) return "Empty stack.";
        StringBuilder sb = new StringBuilder();
        T[] printArr = Stack.Reverse().ToArray();
        sb.Append("[ ");
        foreach (T i in printArr) { sb.Append($"{i} "); }
        sb.Append("]");
        return sb.ToString();
    }

}

