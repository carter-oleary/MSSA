public class QueueNode
{
	public Customer data { get; }
	public QueueNode next;
	public QueueNode(Customer data, QueueNode next = null)
	{
		this.data = data;
	}

	public QueueNode() { }

	public string ToString()
	{
		return data.ToString();
	}
}
