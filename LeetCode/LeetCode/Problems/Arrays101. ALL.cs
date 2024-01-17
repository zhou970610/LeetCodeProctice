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
            ////MaxConsecutiveOnes
            //int[] Title = new int[6] { 1,1,0,1,1,1};
            //int Result = Problem.MaxConsecutiveOnes(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "MaxConsecutiveOnes");
            //Title = new int[6] { 1, 0, 1, 1, 0, 1 };
            //Result = Problem.MaxConsecutiveOnes(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "MaxConsecutiveOnes");

            ////FindNumbers
            //int[] Title = new int[5] { 12, 345, 2, 6, 7896 };
            //int Result = Problem.FindNumbers(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindNumbers");
            //Title = new int[4] { 555, 901, 482, 1771 };
            //Result = Problem.FindNumbers(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindNumbers");

            ////SortedSquares
            //int[] Title = new int[5] { -4, -1, 7, 3, 10 };
            //int[] Result = Problem.SortedSquares(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "SortedSquares");
            //Title = new int[5] { -7, -3, 2, 3, 11 };
            //Result = Problem.SortedSquares(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "SortedSquares");

            ////DuplicateZeros
            //int[] Title = new int[8] { 1, 0, 2, 3, 0, 4, 5, 0 };
            // Problem.DuplicateZeros(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "DuplicateZeros");
            //Title = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            // Problem.DuplicateZeros(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "DuplicateZeros");

            ////Merge
            //int[] Title = new int[6] { 1, 2, 3, 0, 0, 0 };
            //int[] Title2 = new int[3] { 2, 5, 6 };
            //Problem.Merge(Title, 3, Title2, 3);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "Merge");
            //Title = new int[1] { 1 };
            //Title2 = new int[0] { };
            //Problem.Merge(Title, 1, Title2, 0);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "Merge");
            //Title = new int[1] { 0 };
            //Title2 = new int[1] { 1 };
            //Problem.Merge(Title, 0, Title2, 1);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "Merge");

            ////RemoveElement
            //int[] Title = new int[4] { 3, 2, 2, 3 };
            //int Result = Problem.RemoveElement(Title, 3);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveElement");
            //Title = new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 };
            //Result = Problem.RemoveElement(Title, 2);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveElement");
            //Title = new int[12] { 0, 1, 2, 2, 3, 0, 4, 2, 3, 2, 2, 3 };
            //Result = Problem.RemoveElement(Title, 0);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveElement");
            //Title = new int[0] {  };
            //Result = Problem.RemoveElement(Title, 0);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveElement");
            //Title = new int[2] {  3,3};
            //Result = Problem.RemoveElement(Title,5);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveElement");

            //RemoveDuplicates
            int[] Title = new int[4] {  2, 2, 3, 3 };
            int Result = Problem.RemoveDuplicates(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");
            Title = new int[8] { 0, 0, 1, 2, 2, 2, 3,  4 };
            Result = Problem.RemoveDuplicates(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");
            Title = new int[12] { 0,  0, 1, 2, 2, 2, 2, 2, 3, 3, 3, 4 };
            Result = Problem.RemoveDuplicates(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");
            Title = new int[1] { 2 };
            Result = Problem.RemoveDuplicates(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");
        }

        public class Solution
        {
            public int MaxConsecutiveOnes(int[] nums)
            {
                int count = 0;
                int max = 0;
                for (int i = 0; i < nums.Length; i++)
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
                return Math.Max(max, count);
            }
            public int FindNumbers(int[] nums)
            {
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    string n = nums[i].ToString();
                    if (n.Length % 2 == 0)
                    {
                        //even
                        count++;
                    }
                }
                return count;
            }
            public int[] SortedSquares(int[] nums)
            {
                int length = nums.Length;
                int[] result = new int[length];
                int left = 0;
                int right = nums.Length - 1;

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
                if (left == right) result[0] = nums[left] * nums[left];
                return result;
            }
            public void DuplicateZeros(int[] arr)
            {
                int[] tmp = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    tmp[i] = arr[i];
                }

                int index = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = tmp[index];
                    if (tmp[index] == 0 && (i + 1) < arr.Length)
                    {
                        arr[i + 1] = 0;
                        i++;
                    }
                    index++;
                }

            }
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                if (n == 0) return;

                if (m == 0)
                {
                    for (int i = 0; i < nums2.Length; i++)
                    {
                        nums1[i] = nums2[i];
                    }
                    return;
                }

                int[] tmp = new int[nums1.Length - n];
                int index_tmp = 0;
                int index_2 = 0;
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (i < tmp.Length)
                    {
                        tmp[i] = nums1[i];
                    }

                    if (index_tmp == tmp.Length)
                    {
                        nums1[i] = nums2[index_2];
                        index_2++;
                    }
                    else if (index_2 == nums2.Length)
                    {
                        nums1[i] = tmp[index_tmp];
                        index_tmp++;
                    }
                    else if (tmp[index_tmp] < nums2[index_2])
                    {
                        nums1[i] = tmp[index_tmp];
                        index_tmp++;
                    }
                    else
                    {
                        nums1[i] = nums2[index_2];
                        index_2++;
                    }
                }

            }
            public int RemoveElement(int[] nums, int val)
            {
                ////By My Own
                //if(nums.Length == 0) return 0;
                //if(nums.Length == 1) {
                //    if (nums[0] == val)
                //    {
                //        nums=new int[nums.Length-1];
                //        return 0;
                //    }
                //    else
                //    {
                //        return 1;
                //    }
                //}

                //Array.Sort(nums, new 陣列數字一樣丟後面(val));
                //int Result = Array.IndexOf(nums, val);
                //return Result==-1?nums.Length:Result;

                //By Internet
                int count = 0;
                for(int i=0;i<nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[count++] = nums[i];
                    }
                }
                return count; 
            }
            public int RemoveDuplicates(int[] nums)
            {
                int count = 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] != nums[i-1])
                    {
                        nums[count++] = nums[i];
                    }
                }
                return count;
            }
            private class 陣列數字一樣丟後面 : IComparer<int>
            {
                private int k;
                public 陣列數字一樣丟後面(int inputK)
                {
                    k = inputK;
                }
                public int Compare(int x, int y)
                {
                    //return 1 means x>y
                    //return 0 means x==y
                    //return -1 means x<y
                    if (x==k ) return 1;
                    if(y==k) return -1;
                    return 0;
                }
            }
            public string ResultToString(int Result)
            {
                return Result.ToString();
            }
            public string ResultToString(int[] Result)
            {
                string ResultStr = "[";
                for (int i = 0; i < Result.Length; i++)
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
