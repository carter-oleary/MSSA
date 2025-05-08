public static class AssignmentFunctions
{
    public static int LastWordLength(string s)
    {
        string[] arr = s.Split(' ');
        return arr[arr.Length - 1].Length;
    }

    public static void RecursiveHeadPrint(int n)
    {
        if (n > 0)
        {
            RecursiveHeadPrint(n - 1);
            Console.Write(n + " ");
        }
    }

    public static void RecursiveTailPrint(int n)
    {
        if (n > 0)
        {
            Console.Write(n + " ");
            RecursiveTailPrint(n - 1);
        }
    }
    public static bool RecursivePalindrome(string s)
    {
        s = s.ToLower();
        while (s.Length > 1)
        {
            if (s[0] != s[s.Length - 1]) return false;
            else return RecursivePalindrome(s.Substring(1, s.Length - 2));
        }
        return true;
    }

}
