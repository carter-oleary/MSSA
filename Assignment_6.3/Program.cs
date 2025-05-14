// Assignment 6.3
Console.WriteLine("----Assignment 6.3----");
MyQueue<int> myQueue = new MyQueue<int>();
for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enqueuing {i+1}...");
    myQueue.Enqueue(i+1);
}
myQueue.Display();
Console.WriteLine($"Dequeing... " + myQueue.Dequeue());
Console.WriteLine($"Dequeing... " + myQueue.Dequeue());
myQueue.Display();