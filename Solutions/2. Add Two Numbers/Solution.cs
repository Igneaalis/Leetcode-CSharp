namespace Leetcode.Solutions._2._Add_Two_Numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        
        ListNode root = new(0);
        var left = l1; var right = l2; ListNode cur = root;
        int sum = 0;
        while (left is not null || right is not null || sum > 0)
        {
            if (left is not null)
            {
                sum += left.val;
                left = left.next;
            }
            if (right is not null)
            {
                sum += right.val;
                right = right.next;
            }
            cur.next = new ListNode(sum % 10);
            cur = cur.next;
            sum /= 10;
        }
        return root.next;
    }
}