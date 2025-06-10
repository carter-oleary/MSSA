using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Assignment_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Assignment 10.2.1----");
            int[] ints = { 2, -1, 3, -3, 10, -200 };
            var results = from i in ints
                          where i > 0
                          select i;

            Console.Write("#s greater than 0: [ ");
            foreach (var i in results) { Console.Write($"{i} "); }
            Console.WriteLine("]");    

            Console.WriteLine("\n----Assignment 10.2.2----");
            var empList = new List<Employee>();
            empList.Add(new Employee { Id = 1, Name = "Alice", Age = 21, Salary = 10000 });
            empList.Add(new Employee { Id = 2, Name = "Bob", Age = 60, Salary = 50000 });
            empList.Add(new Employee { Id = 3, Name = "Charlie", Age = 55, Salary = 1000 });
            empList.Add(new Employee { Id = 4, Name = "Dave", Age = 25, Salary = 10000 });
            empList.Add(new Employee { Id = 5, Name = "Edgar", Age = 24, Salary = 5000 });
            empList.Add(new Employee { Id = 6, Name = "Fred", Age = 20, Salary = 20000 });
            empList.Add(new Employee { Id = 7, Name = "Gertrude", Age = 70, Salary = 2000 });
            empList.Add(new Employee { Id = 8, Name = "Harry", Age = 31, Salary = 50000 });
            empList.Add(new Employee { Id = 9, Name = "Imogen", Age = 76, Salary = 90000 });
            empList.Add(new Employee { Id = 10, Name = "Julia", Age = 55, Salary = 120000 });

            var empResults = from employee in empList
                             where employee.Age < 30 && employee.Salary > 5000
                             select employee;

            Console.WriteLine("Employees younger than 30 with a salary > $5000:");
            foreach(var e in empResults)
            {
                Console.WriteLine($"Name: {e.Name}, Age: {e.Age}, Salary: {e.Salary}");
            }

            Console.WriteLine("\n----Assignment 10.2.3----");
            string[] cityList = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA",
                "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};

            Console.Write("Enter a char the city should start with: ");
            char start = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("Enter a char the city should end with: ");
            char end = Convert.ToChar(Console.ReadLine().ToUpper());

            var cityResults = from city in cityList
                              where city[0] == start && city[city.Length - 1] == end
                              select city;

            Console.Write($"The city starting with {start} and ending with {end} is ");
            foreach(var city in cityResults) Console.WriteLine(city);

            Console.WriteLine("\n----Assignment 10.2.4----");
            int[] numList = [55, 200, 740, 76, 230, 482, 95];
            Console.Write("The members of the list are: ");
            foreach (int i in numList) Console.Write($"{i} ");
            Console.WriteLine();
            var numResults = from num in numList
                             where num > 80
                             select num;

            Console.WriteLine("The numbers greater than 80 are:");
            foreach(int num in numResults) Console.WriteLine(num);

        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Salary { get; set; }

            public Employee() { }
        }

        
    }
}


