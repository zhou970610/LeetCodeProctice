using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class AddTwoIntegers : Basic
    {
        public override void ShowResult()
        {
            Solution  Problem = new Solution();
            int Result= Problem.Sum(12, 5);
            System.Windows.Forms.MessageBox.Show(Result.ToString(), "Add Two Integers Result 1");
            Result= Problem.Sum(-10,4);
            System.Windows.Forms.MessageBox.Show(Result.ToString(), "Add Two Integers Result 2");
        }

        public class Solution
        {
            public int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
        }
    }
}
