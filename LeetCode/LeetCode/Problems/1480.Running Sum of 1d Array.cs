using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RunningSumof1dArray : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            int[] Title = new int[] { 1, 2, 3, 4 };
            int[] Result = Problem.RunningSum(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 1");
            Title = new int[] { 1, 1, 1, 1, 1 };
            Result = Problem.RunningSum(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
            Title = new int[] { 3, 1, 2, 10, 1 };
            Result = Problem.RunningSum(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
        }

        public class Solution
        {
            public int[] RunningSum(int[] nums)
            {
                int[] Result = new int[nums.Length];
                for (int index = 0; index < nums.Length; index++)
                {
                    if (index > 0)
                    {
                        Result[index] = nums[index] + Result[index - 1];
                    }
                    else
                    {
                        Result[index] = nums[index];
                    }
                }
                return Result;
            }
            public string ResultToString(int[] Result)
            {
                string ResultStr = "";
                for (int index = 0; index < Result.Length; index++)
                {
                    if (index == 0)
                    {
                        ResultStr += "[";
                    }
                    else
                    {
                        ResultStr += ",";
                    }
                    ResultStr += Result[index];
                }
                ResultStr += "]";
                return ResultStr;
            }
        }
    }
}
