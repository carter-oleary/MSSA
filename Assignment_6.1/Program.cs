// Assignment 6.1.1
Console.WriteLine("----Assignment 6.1.1----");
var houseList =  new List<House>();
houseList.Add(new House(1, "Main St", "Ranch"));
houseList.Add(new House(123, "Broadway", "Apartment"));
houseList.Add(new House(4444, "Wrong Circle", "Split Level"));
houseList.Add(new House(145, "Toast Dr", "Ranch"));
houseList.Add(new House(32814, "That St", "Ranch"));

var linkedList = new SingleLinkedListNode<House>(houseList[0]);
var head = linkedList;
for(int i = 0; i <  houseList.Count - 1; i++)
{
    linkedList.next = new SingleLinkedListNode<House>(houseList[i + 1]);
    linkedList = linkedList.next;
}

Console.Write("Enter a house number to search for: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Functions.SearchHouse(head, num));
Console.WriteLine();

//Assignment 6.1.3
Console.WriteLine("----Assignment 6.1.3----");
int[] arr1 = [0, 1, 0, 3, 12];
int[] arr2 = [0];
Console.Write("The initial array is: [ ");
foreach(int i in arr1)
{
    Console.Write($"{i} ");
}
Console.WriteLine("]");
Functions.MoveZeros(arr1);
Console.Write("The new array is: [ ");
foreach (int i in arr1)
{
    Console.Write($"{i} ");
}
Console.WriteLine("]");

Console.Write("The initial array is: [ ");
foreach (int i in arr2)
{
    Console.Write($"{i} ");
}
Console.WriteLine("]");
Functions.MoveZeros(arr2);
Console.Write("The new array is: [ ");
foreach (int i in arr2)
{
    Console.Write($"{i} ");
}
Console.WriteLine("]");