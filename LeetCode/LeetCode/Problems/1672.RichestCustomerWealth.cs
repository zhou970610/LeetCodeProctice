using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RichestCustomerWealth : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            int[][] Title = {
                new int[]{1,2,3},
                new int[]{3,2,1}
            };
            int Result = Problem.MaximumWealth(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 1");
            Title = new int[][] {
                new int[] {1,5},
                new int[] {7,3},
                new int[] {3,5}
            };
            Result = Problem.MaximumWealth(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
            Title = new int[][] {
                new int[] {2,8,7},
                new int[] {7,1,3},
                new int[] {1,9,5}
            };
            Result = Problem.MaximumWealth(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
        }

        public class Solution
        {
            public int MaximumWealth(int[][] accounts)
            {
                int Result = 0;
                for( int customer =0;customer<accounts.Length;customer++)
                {
                    int AllWealth = 0;
                    for(int wealth = 0; wealth < accounts[customer].Length; wealth++)
                    {
                        AllWealth+=accounts[customer][wealth];
                    }
                    if(AllWealth>Result) Result = AllWealth;
                }
                return Result;
            }
            public string ResultToString(int Result)
            {
                return Result.ToString();
            }
        }
    }
}
