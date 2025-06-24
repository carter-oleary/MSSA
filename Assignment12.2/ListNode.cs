using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12._2
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public List<int> ToList()
        {
            List<int> result = new List<int>();
            ListNode current = this;
            while (current != null)
            {
                result.Add(current.val);
                current = current.next;
            }
            return result;
        }
    }
}
