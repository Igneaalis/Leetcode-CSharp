using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions._4._Median_of_Two_Sorted_Arrays
{
    public class Solution
    {
        public int[] MergeTwoSortedArrays(int[] a, int[] b) 
        {
            int n = a.Length + b.Length;
            int[] c = new int[n];
            int i = 0;
            int j = 0;
            while (i + j < n)
            {
                if (i == a.Length)
                {
                    c[i + j] = b[j++];
                    continue;
                }
                if (j == b.Length)
                {
                    c[i + j] = a[i++];
                    continue;
                }
                if (a[i] <= b[j])
                {
                    c[i + j] = a[i++];
                }
                else
                {
                    c[i + j] = b[j++];
                }
                
            }
            return c;
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var c = MergeTwoSortedArrays(nums1, nums2);
            var n1 = nums1.Length;
            var n2 = nums2.Length;
            return (n1 + n2) % 2 == 1 ? c[(n1 + n2) / 2] : (double)(c[(n1 + n2) / 2] + c[(n1 + n2) / 2 - 1]) / 2;
        }
    }
}
