using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class MiddleNode : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            ListNode Title = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            ListNode Result = Problem.MiddleNode(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "MiddleNode");
            Title = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6,null))))));
            Result = Problem.MiddleNode(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "MiddleNode");
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

        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                int count = 0;
                ListNode tmpHead = head;
                while (tmpHead != null)
                {
                    count++;
                    tmpHead = tmpHead.next;
                }

                int middle = count / 2;
                while (middle > 0)
                {
                    head = head.next;
                    middle--;
                }
                return head;
            }
            public string ResultToString(ListNode Result)
            {
                string ResultStr = "[";
               while(Result != null)
                {
                    ResultStr += Result.val.ToString();
                    ResultStr += ",";
                    Result = Result.next;
                }
                ResultStr = ResultStr.Remove(ResultStr.LastIndexOf(','));
                ResultStr += "]";
                return ResultStr.ToString();
            }
        }
    }
}
