using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
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
	}
    class P0021MergeTwoSortedLists
	{
		public ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			var node = new ListNode(0);
			var head = node;

			while (list1 != null && list2 != null)
			{
				if (list1.val < list2.val)
				{
					node.next = list1;
					list1 = list1.next;
				}
				else
				{
					node.next = list2;
					list2 = list2.next;
				}
				node = node.next;
			}
			if (list1 != null) node.next = list1;
			if (list2 != null) node.next = list2;
			return head.next;
		}
	}
}
