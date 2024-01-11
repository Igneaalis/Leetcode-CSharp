# 2. Add Two Numbers

https://leetcode.com/problems/add-two-numbers

## Solution #1

```csharp
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
```

## Solution #2

```csharp
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode root = new(0);
        var left = l1; var right = l2; ListNode prev = root; ListNode cur = root;
        while (left is not null || right is not null)
        {
            if (cur is null)
            {
                cur = new ListNode(0);
                prev.next = cur;
            }
            int sum = cur.val;
            if (left is not null)
            {
                sum += left.val;
            }
            if (right is not null)
            {
                sum += right.val;
            }
            left = left?.next;
            right = right?.next;
            
            if (sum < 10)
            {
                cur.val = sum;
            }
            else
            {
                cur.val = sum - 10;
                cur.next = new ListNode(1);
            }
            prev = cur;
            cur = cur.next;
        }
        return root;
    }
}
```