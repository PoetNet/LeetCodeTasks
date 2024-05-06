using System.Net.Http.Headers;

namespace Tasks.Daily.April2024;

public static class NodesRemover
{
    public static ListNode RemoveNodes(ListNode head)
    {
        head = ReverseList(head);
        int maximum = 0;
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            maximum = Math.Max(maximum, current.val);
            if (current.val < maximum)
            {
                ListNode deleted = current;
                current = current.next;

                if (prev != null)
                {
                    prev.next = current;
                }

                deleted.next = null;
            }
            else
            {
                prev = current;
                current = current.next;
            }
        }

        return ReverseList(head);
    }

    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode nextTemp = null;

        while (current != null)
        {
            nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }

        return prev;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
