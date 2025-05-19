//Assignment 7.2.1
using System.Security.Cryptography;
using System.Text;

Console.WriteLine("----Assignment 7.2.1----");
Console.Write("Enter length for the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i  = 0; i < n; i++)
{
    Console.Write($"Element {i}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Initial Array: {PrintArray(arr)}");
ShellSort(arr);
Console.WriteLine($"Shell Sorted Array: {PrintArray(arr)}");


Console.WriteLine();
//Assignment 7.2.2
Console.WriteLine("----Assignment 7.2.2----");
string[] sArr = { "hello", "avacado", "intelligent" };
foreach(string s in sArr)
{
    Console.WriteLine($"Initial String: {s}");
    string rev = ReverseVowels(s);
    Console.WriteLine($"Reversed String {rev}");
}


Console.WriteLine();
//Assignment 7.2.3
Console.WriteLine("----Assignment 7.2.3----");
string s1 = "anagram";
string s2 = "nagaram";
if (CheckAnagram(s1, s2))
{
    Console.WriteLine($"{s1} and {s2} are anagrams of one another.");
}
else Console.WriteLine($"{s1} and {s2} are not anagrams of one another.");
s1 = "rat";
s2 = "car";
if (CheckAnagram(s1, s2))
{
    Console.WriteLine($"{s1} and {s2} are anagrams of one another.");
}
else Console.WriteLine($"{s1} and {s2} are not anagrams of one another.");


void ShellSort(int[] arr)
{
    int n = arr.Length;

    for (int gap = n / 2; gap > 0; gap /= 2)
    {
        for (int i = gap; i < n; i++)
        {
            int temp = arr[i];
            int j = i;
            while (j >= gap && arr[j - gap] > temp)
            {
                arr[j] = arr[j - gap];
                j -= gap;
            }
            arr[j] = temp;
        }
    }
}

string ReverseVowels(string s)
{
    var charIndices = new List<int>();
    string lower = s.ToLower();
    char[] reverse = s.ToCharArray();
    for (int i = 0; i < lower.Length; i++)
    {
        switch (lower[i])
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                charIndices.Add(i);
                break;
            default: break;
        }
    }
    for (int i = 0; i < charIndices.Count / 2; i++)
    {
        char temp = reverse[charIndices[i]];
        reverse[charIndices[i]] = reverse[charIndices[charIndices.Count - 1 - i]];
        reverse[charIndices[charIndices.Count - 1 - i]] = temp;
    }
    return new string(reverse);
}

string PrintArray(int[] arr)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("[ ");
    foreach (int i in arr) { sb.Append(i + " "); }
    sb.Append("]");
    return sb.ToString();
}

bool CheckAnagram(string s1, string s2)
{
    if (s1.Length != s2.Length) return false;
    char[] sorted1 = s1.ToLower().ToCharArray();
    Array.Sort(sorted1);
    char[] sorted2 = s2.ToLower().ToCharArray();
    Array.Sort(sorted2);
    return new string(sorted1).Equals(new string(sorted2));
}