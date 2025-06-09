using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

Console.WriteLine("----Assignment 10.1----");

var list = new List<Student>();

list.Add(new Student(1, "Carter", "OLeary"));
list.Add(new Student(2, "John", "Doe"));
string jsonSer = JsonSerializer.Serialize(list);
Console.WriteLine($"Json String: {jsonSer}");
list = JsonSerializer.Deserialize<List<Student>>(jsonSer);
foreach(Student s  in list) Console.WriteLine(s);


string file = @"C:\Users\Carter\Desktop\test\test.txt";
var xmlSer = new XmlSerializer(typeof(List<Student>));
var writer = new StreamWriter(file);
xmlSer.Serialize(writer, list);
writer.Close();
var reader = new StreamReader(file);
var xmlData = xmlSer.Deserialize(reader) as List<Student>;
foreach (Student s in xmlData) Console.WriteLine(s);
