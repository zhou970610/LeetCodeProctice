using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class RansomNote : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            string ransomNote = "a";
            string magazine = "b";
            bool Result = Problem.RansomNote(ransomNote, magazine);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RansomNote");
            ransomNote = "nrsaytmyfrgbaaad";
            magazine = "aagdsgfdjnrsytmyfgbaadzsjmsfb";
            Result = Problem.RansomNote(ransomNote, magazine);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RansomNote");
            ransomNote = "aa";
            magazine = "aab";
            Result = Problem.RansomNote(ransomNote, magazine);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "RansomNote");
        }

        public class Solution
        {
            public bool RansomNote(string ransomNote, string magazine)
            {
                //Try Dictionary<char,int> !!!
                Dictionary<char, int> DicOfMag = new Dictionary<char, int>();
                for (int i = 0; i < magazine.Length; i++)
                {
                                       if (DicOfMag.ContainsKey(magazine[i]))
                    {
                        DicOfMag[magazine[i]]++;
                    }
                    else
                    {
                        DicOfMag.Add(magazine[i], 1);
                    }
                }

                for (int i = 0; i < ransomNote.Length; i++)
                {
                    if (DicOfMag.ContainsKey(ransomNote[i]))
                    {
                        if (DicOfMag[ransomNote[i]] == 0)
                        {
                            return false;
                        }
                        DicOfMag[ransomNote[i]]--;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;


            }
            public string ResultToString(bool Result)
            {
                // string ResultStr = "[";
                //while(Result != null)
                // {
                //     ResultStr += Result.val.ToString();
                //     ResultStr += ",";
                //     Result = Result.next;
                // }
                // ResultStr = ResultStr.Remove(ResultStr.LastIndexOf(','));
                // ResultStr += "]";
                return Result.ToString();
            }
        }
    }
}
