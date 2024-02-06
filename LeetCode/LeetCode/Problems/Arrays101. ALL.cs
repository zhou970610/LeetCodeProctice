using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

            ////RemoveDuplicates
            //int[] Title = new int[4] {  2, 2, 3, 3 };
            //int Result = Problem.RemoveDuplicates(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");
            //Title = new int[8] { 0, 0, 1, 2, 2, 2, 3,  4 };
            //Result = Problem.RemoveDuplicates(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");
            //Title = new int[12] { 0,  0, 1, 2, 2, 2, 2, 2, 3, 3, 3, 4 };
            //Result = Problem.RemoveDuplicates(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");
            //Title = new int[1] { 2 };
            //Result = Problem.RemoveDuplicates(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RemoveDuplicates");

            ////CheckIfExist
            //int[] Title = new int[4] { 10, 2, 5, 3 };
            //bool Result = Problem.CheckIfExist(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "CheckIfExist");
            //Title = new int[4] { 3, 1, 7, 11 };
            //Result = Problem.CheckIfExist(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "CheckIfExist");
            //Title = new int[12] { 3, 1, 7, 11, 10, 2, 5, 3, 53, 23, 43, 14 };
            //Result = Problem.CheckIfExist(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "CheckIfExist");
            //Title = new int[1] { 2 };
            //Result = Problem.CheckIfExist(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "CheckIfExist");

            ////ValidMountainArray
            //int[] Title = new int[4] { 10, 2, 5, 3 };
            //bool Result = Problem.ValidMountainArray(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ValidMountainArray");
            //Title = new int[4] { 0,3,2,1};
            //Result = Problem.ValidMountainArray(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ValidMountainArray");
            //Title = new int[3] { 3, 5,5 };
            //Result = Problem.ValidMountainArray(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ValidMountainArray");
            //Title = new int[2] { 2,1 };
            //Result = Problem.ValidMountainArray(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ValidMountainArray");

            ////ReplaceElements
            //int[] Title = new int[6] { 17, 18, 5, 4, 6, 1 };
            //int[] Result = Problem.ReplaceElements(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ReplaceElements");
            //Title = new int[1] { 400 };
            //Result = Problem.ReplaceElements(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ReplaceElements");
            //Title = new int[3] { 3, 5,5 };
            //Result = Problem.ReplaceElements(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ReplaceElements");
            //Title = new int[2] { 2,1 };
            //Result = Problem.ReplaceElements(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ReplaceElements");

            ////MoveZeroes
            //int[] Title = new int[5] { 0, 1, 0, 3, 12 };
            // Problem.MoveZeroes(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "MoveZeroes");
            //Title = new int[1] { 400 };
            // Problem.MoveZeroes(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "MoveZeroes");
            //Title = new int[3] { 3, 5,5 };
            // Problem.MoveZeroes(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "MoveZeroes");
            //Title = new int[2] { 2,1 };
            // Problem.MoveZeroes(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Title), "MoveZeroes");

            ////SortArrayByParity
            //int[] Title = new int[5] { 0, 1, 0, 3, 12 };
            //int[] Result = Problem.SortArrayByParity(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "SortArrayByParity");
            //Title = new int[4] { 3, 1, 2, 4 };
            //Result = Problem.SortArrayByParity(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "SortArrayByParity");
            //Title = new int[3] { 3, 5, 5 };
            //Result = Problem.SortArrayByParity(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "SortArrayByParity");
            //Title = new int[1] { 0 };
            //Result = Problem.SortArrayByParity(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "SortArrayByParity");

            ////HeightChecker
            //int[] Title = new int[6] { 1, 1, 4, 2, 1, 3 };
            //int Result = Problem.HeightChecker(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "HeightChecker");
            //Title = new int[5] { 5, 1, 2, 3, 4 };
            //Result = Problem.HeightChecker(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "HeightChecker");
            //Title = new int[5] { 1, 2, 3, 4, 5 };
            //Result = Problem.HeightChecker(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "HeightChecker");
            //Title = new int[1] { 1 };
            //Result = Problem.HeightChecker(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "HeightChecker");

            ////ThirdMax
            //int[] Title = new int[3] { 3, 2, 1 };
            //int Result = Problem.ThirdMax(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ThirdMax");
            //Title = new int[2] { 1, 2 };
            //Result = Problem.ThirdMax(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ThirdMax");
            //Title = new int[4] { 2, 2, 3, 1 };
            //Result = Problem.ThirdMax(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ThirdMax");
            //Title = new int[3] { 1 ,1,2};
            //Result = Problem.ThirdMax(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "ThirdMax");

            //FindDisappearedNumbers
            int[] Title = new int[8] { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> Result = Problem.FindDisappearedNumbers(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindDisappearedNumbers");
            Title = new int[2] { 1, 1 };
            Result = Problem.FindDisappearedNumbers(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindDisappearedNumbers");
            Title = new int[4] { 2, 2, 3, 1 };
            Result = Problem.FindDisappearedNumbers(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindDisappearedNumbers");
            Title = new int[1] { 1 };
            Result = Problem.FindDisappearedNumbers(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "FindDisappearedNumbers");
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
                for (int i = 0; i < nums.Length; i++)
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
                    if (nums[i] != nums[i - 1])
                    {
                        nums[count++] = nums[i];
                    }
                }
                return count;
            }
            public bool CheckIfExist(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == 2 * arr[j]) return true;
                        if (arr[j] == 2 * arr[i]) return true;
                    }
                }
                return false;
            }
            public bool ValidMountainArray(int[] arr)
            {
                if (arr.Length < 3) return false;
                if (arr[0] >= arr[1])
                {
                    return false;
                }
                bool Increase = true;
                for (int i = 2; i < arr.Length; i++)
                {
                    if (arr[i - 1] == arr[i]) return false;
                    if (arr[i - 1] > arr[i] && Increase)
                    {
                        Increase = false;
                        continue;
                    }
                    if (arr[i - 1] < arr[i] && !Increase) return false;

                }

                return !Increase;
            }
            public int[] ReplaceElements(int[] arr)
            {
                if (arr.Length < 2)
                {
                    arr[0] = -1;
                }
                else
                {
                    int max = -1;
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        if (max > arr[i])
                        {
                            arr[i] = max;
                        }
                        else
                        {
                            int t = arr[i];
                            arr[i] = max;
                            max = t;
                        }
                    }
                }
                return arr;
            }
            public void MoveZeroes(int[] nums)
            {

                //for(int i = 0; i < nums.Length; i++)
                //{
                //    if (nums[i] == 0)
                //    {
                //        for(int j = i + 1; j < nums.Length; j++)
                //        {
                //            if (nums[j] == 0) continue;
                //            int tmp = nums[i];
                //            nums[i] = nums[j];
                //            nums[j] = tmp;
                //            break;
                //        }
                //    }
                //}

                int zeroIndex = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[zeroIndex] != 0) zeroIndex++;
                    if (nums[i] != 0 && i > zeroIndex)
                    {
                        nums[zeroIndex] = nums[i];
                        nums[i] = 0;
                        zeroIndex++;
                    }
                }
            }
            public int[] SortArrayByParity(int[] nums)
            {
                int evenIndex = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        //even
                        if (i != evenIndex)
                        {
                            int t = nums[evenIndex];
                            nums[evenIndex] = nums[i];
                            nums[i] = t;
                        }
                        evenIndex++;
                    }
                }
                return nums;
            }
            public int HeightChecker(int[] heights)
            {
                int count = 0;
                int[] tmpArray = new int[heights.Length];


                for (int i = 0; i < tmpArray.Length; i++)
                {
                    tmpArray[i] = heights[i];
                }

                for (int i = 0; i < tmpArray.Length; i++)
                {
                    for (int j = i + 1; j < tmpArray.Length; j++)
                    {
                        if (tmpArray[i] > tmpArray[j])
                        {
                            int t = tmpArray[i];
                            tmpArray[i] = tmpArray[j];
                            tmpArray[j] = t;
                        }
                    }
                }

                for (int i = 0; i < tmpArray.Length; i++)
                {
                    if (tmpArray[i] != heights[i]) count++;
                }

                return count;
            }
            public int ThirdMax(int[] nums)
            {
                int Max_count = 0;

                long[] Max_3 = new long[3] { long.MinValue, long.MinValue, long.MinValue };
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < Max_3.Length; j++)
                    {
                        if (nums[i] > Max_3[j])
                        {
                            for (int k = Max_3.Length - 1; k > j; k--)
                            {
                                Max_3[k] = Max_3[k - 1];
                            }
                            Max_3[j] = nums[i];
                            Max_count++;
                            break;
                        }
                        else if (nums[i] == Max_3[j]) break;
                    }
                }
                if (Max_count < 3)
                {
                    return (int)Max_3[0];
                }
                return (int)Max_3[2];
            }
            public IList<int> FindDisappearedNumbers(int[] nums)
            {
                List<int> result = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    result.Add(i + 1);
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    result.Remove(nums[i]);
                }

                return result;
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
                    if (x == k) return 1;
                    if (y == k) return -1;
                    return 0;
                }
            }
            public string ResultToString(object Result)
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
                if (Result.Length >= 2)
                {
                    ResultStr = ResultStr.Remove(ResultStr.LastIndexOf(','));
                }
                ResultStr += "]";
                return ResultStr;
            }
            public string ResultToString(IList<int> Result)
            {
                string ResultStr = "[";
                for (int i = 0; i < Result.Count; i++)
                {
                    ResultStr += Result[i].ToString();
                    ResultStr += ",";
                }
                if (Result.Count >= 1)
                {
                    ResultStr = ResultStr.Remove(ResultStr.LastIndexOf(','));
                }
                ResultStr += "]";
                return ResultStr;
            }
        }
    }
}
