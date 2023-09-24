using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class FizzBuzz : Basic
    {
        public override void ShowResult()
        {
            Solution Problem = new Solution();
            int Title = 1;
            IList<string> Result = Problem.FizzBuzz(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 1");
            //Title = 3;
            //Result = Problem.FizzBuzz(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
            //Title = 5;
            //Result = Problem.FizzBuzz(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
            //Title = 15;
            //Result = Problem.FizzBuzz(Title);
            //System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
            Title =100000;
            Result = Problem.FizzBuzz(Title);
            System.Windows.Forms.MessageBox.Show(Problem.ResultToString(Result), "Add Two Integers Result 2");
        }

        public class Solution
        {
            public IList<string> FizzBuzz(int n)
            {
                IList<string> Result = new List<string>(); 
                for(int index = 1; index <= n; index++)
                {
                    //Testcase 241 ms
                    string tmp = "";
                    if (index % 3 == 0)
                    {
                        tmp += "Fizz";
                    }
                    if (index % 5 == 0)
                    {
                        tmp += "Buzz";
                    }
                    if (tmp == "")
                    {
                        tmp = index.ToString();
                    }
                    Result.Add(tmp);

                    //Testcase 254ms, Accepted 119ms, 57.4MB
                    if (index % 15 == 0)
                    {
                        Result.Add("FizzBuzz");
                    }
                    else if(index % 3 == 0)
                    {
                        Result.Add("Fizz");
                    }
                    else if (index % 5 == 0)
                    {
                        Result.Add("Buzz"); 
                    }
                    else
                    {
                        Result.Add(index.ToString());
                    }
                }
                return Result;
            }
            public string ResultToString(IList<string> Result)
            {
                string ResultStr = "[";
                foreach(string item in Result)
                {
                    ResultStr += item;
                    ResultStr += ",";
                }
                ResultStr=ResultStr.Remove( ResultStr.LastIndexOf(','));
                ResultStr += "]";
                return ResultStr.ToString();
            }
        }
    }
}
