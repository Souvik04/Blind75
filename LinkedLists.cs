using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75
{
    public class LinkedLists
    {
        /// <summary>
        /// Ref: https://leetcode.com/problems/reverse-linked-list/
        /// Recursive solution
        /// </summary>
        /// <param name="head"></param>
        /// <param name="newNode"></param>
        /// <returns>Reversed linked linked node</returns>
        public ListNode ReverseListRecursive(ListNode head, ListNode newNode = null)
        {
            if (head == null)
            {
                return newNode;
            }

            ListNode next = head.next;
            head.next = newNode;
            return ReverseListRecursive(next, head);
        }

        /// <summary>
        /// Ref: https://leetcode.com/problems/reverse-linked-list/
        /// Iterative solution
        /// </summary>
        /// <param name="head"></param>
        /// <returns>Reversed linked list node</returns>
        public ListNode ReverseListIterative(ListNode head)
        {
            ListNode newNode = null;

            while (head != null)
            {
                ListNode temp = head.next;
                head.next = newNode;
                newNode = head;
                head = temp;
            }

            return newNode;
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

}
