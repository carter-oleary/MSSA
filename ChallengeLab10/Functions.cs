using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLab10
{
    public static class Functions
    {
        public static char? FindRandomChar(string s, string t)
        {
            if (s.Length == 0) return t[0];
            List<char> chars = s.ToList();
            foreach (char c in t)
            {
                if (!chars.Contains(c)) return c;
            }
            return null;
        }

        public static void MergeArrays(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }
            if (n == 0) return;
            int[] temp = new int[nums1.Length];
            int p1 = 0;
            int p2 = 0;
            for (int i = 0; i < m + n; i++)
            {
                if (p2 == nums2.Length)
                {
                    temp[i] = nums1[p1];
                    p1++;
                }
                else if (nums1[p1] > nums2[p2] || (nums1[p1] == 0 && p1 == m))
                {
                    temp[i] = nums2[p2];
                    p2++;
                }
                else
                {
                    temp[i] = nums1[p1];
                    p1++;
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                nums1[i] = temp[i];
            }
        }
    }
}
