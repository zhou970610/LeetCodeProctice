using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class NumberofStepstoReduceaNumbertoZero : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            int Title =7;
            int Result = Problem.NumberOfSteps(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result");
             Title = 4;
             Result = Problem.NumberOfSteps(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result");
             Title = 123;
             Result = Problem.NumberOfSteps(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result");
             Title = 1000000;
             Result = Problem.NumberOfSteps(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result");
        }

        public class Solution
        {
            public int NumberOfSteps(int num)
            {
                //int count=0;
                //while (num != 0)
                //{
                //   if(num % 2 == 0)
                //    {
                //        num /= 2;
                //    }
                //    else
                //    {
                //        num -= 1;
                //    }
                //    count++;
                //}
                //return count;

                if (num == 0) return 0;

                int Bits = 0;
                int Ones = 0;

                while(num > 0)
                {
                    Bits++;
                    Ones += num & 1;
                    num >>= 1;
                }

                return Bits + Ones - 1;
            }
            public string ResultToString(int Result)
            {
                return Result.ToString();
            }
        }
    }
}
