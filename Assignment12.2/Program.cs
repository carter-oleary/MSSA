namespace Assignment12._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListNode test = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
            Console.WriteLine("Original List:");
            PrintList(test);
            ListNode result = RemoveElements(test, 6);
            Console.WriteLine("List after removing elements with value 6:");
            PrintList(result);
        }

        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            while (head.val == val)
            {
                head = head.next;
                if (head == null) return null; // If all nodes are removed
            }
            ListNode current = head;
            while (current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next; // Remove the node
                }
                else
                {
                    current = current.next; // Move to the next node
                }
            }

            return head;
        }

        public static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
