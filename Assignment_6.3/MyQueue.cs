public class MyQueue<T>
{
    public LinkedList<T> Queue { get; set; }

    public MyQueue()
    {
        Queue = new LinkedList<T>();
    }

    public void Enqueue(T item)
    {
        Queue.AddLast(item);
    }

    public T Dequeue()
    {
        T item = Queue.First.Value;
        Queue.RemoveFirst();
        return item;
    }

    public void Display()
    {
        foreach (var item in Queue)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
