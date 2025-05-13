using System.Text;

public class MyStack
{
    public int[] Stack {  get; set; }

    public MyStack(int[] stack)
    {
        Stack = stack.Reverse().ToArray();
    }

    public void Push(int i)
    {
        int[] temp = Stack;
        Array.Resize(ref temp, Stack.Length + 1);
        Stack = temp;
        Stack[Stack.Length - 1] = i;
    }

    public int Pop()
    {
        int popped = Stack[Stack.Length - 1];
        Stack = Stack.Take(Stack.Length - 1).ToArray();
        return popped;
    }

    public int Peek()
    {
        return Stack[Stack.Length - 1]; 
    }

    public string ToString()
    {
        if (Stack.Length == 0) return "Empty stack.";
        StringBuilder sb = new StringBuilder();
        int[] printArr = Stack.Reverse().ToArray();
        sb.Append("[ ");
        foreach (int i in printArr) { sb.Append($"{i} "); }
        sb.Append("]");
        return sb.ToString();
    }

}

