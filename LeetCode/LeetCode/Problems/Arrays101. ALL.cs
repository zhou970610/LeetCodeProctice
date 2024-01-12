using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class Arrays101 : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            int[] Title = new int[6] { 1,1,0,1,1,1};
            int Result = Problem.MaxConsecutiveOnes(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "MaxConsecutiveOnes");
            Title = new int[6] { 1, 0, 1, 1, 0, 1 };
            Result = Problem.MaxConsecutiveOnes(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "MaxConsecutiveOnes");
            Title = new int[5] { 12, 345, 2, 6, 7896 };
            Result = Problem.FindNumbers(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindNumbers");
            Title = new int[4] { 555, 901, 482, 1771 };
            Result = Problem.FindNumbers(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindNumbers");
            Title = new int[5] { -4, -1, 7, 3, 10 };
            int[] Result2 = Problem.SortedSquares(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result2), "SortedSquares");
            Title = new int[5] { -7, -3, 2, 3, 11 };
            Result2 = Problem.SortedSquares(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result2), "SortedSquares");
        }

        public class Solution
        {
            public int MaxConsecutiveOnes(int[] nums)
            {
                int count = 0;
                int max = 0;
                for(int i=0;i< nums.Length; i++)
                {
                    if (nums[i] == 1)
                    {
                        count++;
                    }
                    else
                    {
                        if (max < count) { max = count; }
                        count = 0;
                    }
                }
                return Math.Max(max,count);
            }
            public int FindNumbers(int[] nums)
            {
                int count = 0;
                for(int i =0;i< nums.Length;i++)
                {
                    string n = nums[i].ToString();
                    if(n.Length%2 == 0)
                    {
                        //even
                        count ++;
                    }
                }
                return count;
            }
            public int[] SortedSquares(int[] nums)
            {
                //int[] output = new int[nums.Length];
                //for(int i = 0; i < nums.Length; i++)
                //{
                //    output[i] = nums[i] * nums[i];
                //}
                //for(int i=0;i < output.Length; i++)
                //{
                //    for(int j = i + 1; j < output.Length; j++)
                //    {
                //        int t = output[j];
                //        if (output[i] > output[j])
                //        {
                //            output[j] = output[i];
                //            output[i] = t;
                //        }
                //    }
                //}
                //return output;

                int length = nums.Length;
                int[] result = new int[length];
                int left = 0;
                int right = nums.Length-1;

                while (left < right)
                {
                    if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                    {
                        result[length - 1] = nums[left] * nums[left];
                        left++;
                    }
                    else
                    {
                        result[length - 1] = nums[right] * nums[right];
                        right--;
                    }
                    length--;
                }
                if(left==right) result[0] = nums[left] * nums[left];
                return result;
            }
            public string ResultToString(int Result)
            {
                return Result.ToString();
            }
            public string ResultToString(int[] Result)
            {
                string ResultStr = "[";
                for(int i=0; i< Result.Length ; i++)
                {
                    ResultStr += Result[i].ToString();
                    ResultStr += ",";
                }
                ResultStr = ResultStr.Remove(ResultStr.LastIndexOf(','));
                ResultStr += "]";
                return ResultStr;
            }
        }
    }
}
