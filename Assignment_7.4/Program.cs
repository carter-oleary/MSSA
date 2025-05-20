// Assignment 7.4
Console.WriteLine("----Assignment 7.4----");
ParkingSystem ps = new ParkingSystem(1, 1, 0);
int[] cars = [1, 2, 3, 1];
foreach (int car in cars)
{
    string result = (ps.AddCar(car)) ? "Car successfully parked" : "That car won't fit";
    Console.WriteLine(result);
}