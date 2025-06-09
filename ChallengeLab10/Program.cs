using ChallengeLab10;
using System.Text;

Console.WriteLine("----CHALLENGE LAB 10.1----");
string s = "abcd";
string t = "bcaed";
Console.WriteLine(Functions.FindRandomChar(s, t));
s = "";
t = "y";
Console.WriteLine(Functions.FindRandomChar(s, t));


Console.WriteLine("\n----CHALLENGE LAB 10.2----");
int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int[] nums2 = { 2, 5, 6 };
Console.WriteLine($"Original Arrays: {PrintArray(nums1)}, {PrintArray(nums2)}");
Functions.MergeArrays(nums1, 3, nums2, 3);
Console.WriteLine($"Merged Array: {PrintArray(nums1)}");


string PrintArray(int[] nums)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("[ ");
    foreach (int i in nums) sb.Append($"{i} ");
    sb.Append("]");
    return sb.ToString();
}
