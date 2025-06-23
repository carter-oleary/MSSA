namespace Assignment12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Assignment 12.1.1----");
            Console.WriteLine(CanConstruct("a", "b"));
            Console.WriteLine(CanConstruct("aa", "ab"));
            Console.WriteLine(CanConstruct("aa", "aab"));

            Console.WriteLine("\n----Assignment 12.1.2----");
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(2, new ListNode(1)))));
            Console.WriteLine(IsPalindrome(head)); // Should return true
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var magazineCount = new Dictionary<char, int>();
            foreach (var c in magazine)
            {
                if (magazineCount.ContainsKey(c))
                {
                    magazineCount[c]++;
                }
                else
                {
                    magazineCount[c] = 1;
                }
            }

            foreach(var c in ransomNote)
            {
                if(magazineCount.ContainsKey(c) && magazineCount[c] > 0)
                {
                    magazineCount[c]--;
                }
                else
                {
                    return false; // If the character is not available or exhausted, return false
                }
            }

            return true; // If all characters in ransomNote can be constructed from magazine
        }

        static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;
            // Find the middle of the linked list using the slow and fast pointer technique
            ListNode slow = head, fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            // Reverse the second half of the linked list
            ListNode prev = null, current = slow;
            while (current != null)
            {
                ListNode nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }
            // Compare the first half and the reversed second half
            ListNode firstHalf = head, secondHalf = prev;
            while (secondHalf != null) // Only need to check the second half
            {
                if (firstHalf.val != secondHalf.val)
                {
                    return false; // If values differ, it's not a palindrome
                }
                firstHalf = firstHalf.next;
                secondHalf = secondHalf.next;
            }
            return true; // If all values matched, it is a palindrome
        }
    }
}
