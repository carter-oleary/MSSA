namespace Assignment12._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Assignment 12.3----");
            string[] s = { "abbaca", "azxxzy" };
            foreach(string str in s)
            {
                Console.WriteLine($"Original string: {str}");
                Console.WriteLine($"Removed string: {RemoveDuplicates(str)}");
            }
        }

        public static string RemoveDuplicates(string s)
        {
            if(s.Length <= 1) return s;

            var chars = new Stack<char>();
            foreach (char c in s)
            {
                if(chars.Count == 0)
                {
                    chars.Push(c);
                    continue;
                }   
                if(c == chars.Peek())
                {
                    chars.Pop();
                    continue;
                }
                chars.Push(c);
            }
            return new string(chars.Reverse().ToArray());

        }
    }
}
