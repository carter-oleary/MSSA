public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public Student() { }

    public override string ToString()
    {
        return $"ID: {Id}\nName: {LastName}, {FirstName}";
    }
}

