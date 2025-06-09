using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

Console.WriteLine("----Assignment 10.1----");

Student? student = new Student(1, "Carter", "OLeary");
string jsonSer = JsonSerializer.Serialize(student);
Console.WriteLine($"Json String: {jsonSer}");
student = JsonSerializer.Deserialize<Student>(jsonSer);
Console.WriteLine(student.ToString());

string file = @"C:\Users\Carter\Desktop\test\test.txt";
var xmlSer = new XmlSerializer(typeof(Student));
var writer = new StreamWriter(file);
xmlSer.Serialize(writer, student);
writer.Close();
var reader = new StreamReader(file);
var xmlData = xmlSer.Deserialize(reader) as Student;
Console.WriteLine(xmlData);
