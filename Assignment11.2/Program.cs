namespace Assignment11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Assignment 11.2.1----");
            int[] prices1 = [7, 1, 5, 3, 6, 4];
            int[] prices2 = [7, 6, 4, 3, 1];
            Console.WriteLine("Max Profit for prices1: " + string.Join(", ", prices1));
            Console.WriteLine(MaxProfit(prices1));
            Console.WriteLine("Max Profit for prices2: " + string.Join(", ", prices2));
            Console.WriteLine(MaxProfit(prices2));

            Console.WriteLine("\n----Assignment 11.2.2----");
            ListNode node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            Console.Write("Original List: ");
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            ListNode reversedNode = ReverseListRecursive(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
            Console.Write("\nReversed List: ");
            while (reversedNode != null)
            {
                Console.Write(reversedNode.val + " ");
                reversedNode = reversedNode.next;
            }


        }

        public static int MaxProfit(int[] prices)
        {
            // Check length 0 or 1 edge case
            if (prices.Length <= 1) return 0;

            // Check if largest price comes after the smallest price
            int minPrice = prices.Min();
            int maxPrice = prices.Max();
            var priceList = prices.ToList();
            if (priceList.IndexOf(minPrice) < priceList.IndexOf(maxPrice)) return maxPrice - minPrice;
            minPrice = prices[0]; // Reset minPrice to the first element
            int maxProfit = 0;
            for (int i = 1; i < prices.Length - 1; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                if (prices[i + 1] > minPrice)
                {
                    maxProfit = Math.Max(maxProfit, prices[i + 1] - minPrice);
                }
            }

            return maxProfit;
        }

        public static ListNode ReverseListRecursive(ListNode head)
        {
            // Base case: if the list is empty or has only one node
            if (head == null || head.next == null)
                return head;
            // Recursive case: reverse the rest of the list
            ListNode newHead = ReverseListRecursive(head.next);
            // Make the next node point to the current node
            head.next.next = head;
            head.next = null; // Set the next of the current node to null
            return newHead;
        }

        public static ListNode ReverseListIterative(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode nextTemp = current.next; // Store the next node
                current.next = prev; // Reverse the link
                prev = current; // Move prev to current
                current = nextTemp; // Move to the next node
            }
            return prev; // New head of the reversed list
        }
    }
}
