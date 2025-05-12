public class SingleLinkedListNode<T>
{
    public T Val;
    public SingleLinkedListNode<T> next;

    public SingleLinkedListNode(T val, SingleLinkedListNode<T> next = null) 
    {
        Val = val;
        this.next = next;
    }
}
