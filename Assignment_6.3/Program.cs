// Assignment 6.3
Console.WriteLine("----Assignment 6.3----");
MyQueue myQueue = new MyQueue();
myQueue.Display();
myQueue.Enqueue(new Customer(1, "Abby"));
myQueue.Enqueue(new Customer(2, "Blake"));
myQueue.Enqueue(new Customer(3, "David"));
myQueue.Enqueue(new Customer(4, "John"));
myQueue.Display();
Console.WriteLine($"Dequeing... " + myQueue.Dequeue());
Console.WriteLine($"Dequeing... " + myQueue.Dequeue());
myQueue.Display();