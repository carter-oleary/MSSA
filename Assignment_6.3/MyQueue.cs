public class MyQueue
{
    private QueueNode head;
    private QueueNode tail;
    private int count;


    public MyQueue()
    {
        head = new QueueNode();
        tail = head;
        count = 0;
    }

    public void Enqueue(Customer item)
    {
        QueueNode temp = new QueueNode(item);
        if (count == 0)
        {
            head = temp;
            tail = temp;
        }
        else
        {
            tail.next = temp;
            tail = temp;
        }
        count++;

    }

    public string Dequeue()
    {
        if(count == 0)
        {
            return "Queue is empty";
        }
        QueueNode temp = head;
        head = head.next;
        count--;
        return temp.data.ToString();
    }

    public void Display()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty.");
            return;
        }
        QueueNode temp = head;
        while (temp != null)
        {
            Console.Write(temp.data.Name + " ");
            temp = temp.next;
        }
        Console.WriteLine();
        
    }
}
