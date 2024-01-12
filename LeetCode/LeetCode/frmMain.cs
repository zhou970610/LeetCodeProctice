using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeetCode.Problems;

namespace LeetCode
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //lbProblems.Items.Clear();

            ////Read File Names
            DirectoryInfo slnDir = GetSLNDirectory();
            DirectoryInfo CodeDir = new DirectoryInfo(System.IO.Path.Combine(slnDir.FullName, "LeetCode", "Problems"));
            foreach (FileInfo f in CodeDir.GetFiles())
            {
                lbProblems.Items.Add(f.Name);
            }
        }

        private DirectoryInfo GetSLNDirectory()
        {
            DirectoryInfo FindDir = new DirectoryInfo(Environment.CurrentDirectory);
            while (!FindDir.GetFiles( "*.sln").Any())
            {
                FindDir = FindDir.Parent;
            }
            return FindDir;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if(lbProblems.SelectedIndex == -1)
            {
                MessageBox.Show("Didn't Select a Problem.","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string[] SelectedProblem = lbProblems.SelectedItem.ToString().Split('.');
            
            Basic Problem = new Basic();

            switch (SelectedProblem[0])
            {
                case "2235": //2235.Add Two Integers
                    Problem = new AddTwoIntegers();
                    Problem.ShowResult();
                    break;

                case "2236": //2236.Root Equals Sum Of Children
                    Problem = new RootEqualsSumOfChildren();
                    Problem.ShowResult();
                    break;

                case "1480": //1480.Running Sum of 1d Array
                    Problem = new RunningSumof1dArray();
                    Problem.ShowResult();
                    break;

                case "1672": //1672.Richest Customer Wealth
                    Problem = new RichestCustomerWealth();
                    Problem.ShowResult();
                    break;

                case "412": //412. Fizz Buzz
                    Problem = new FizzBuzz();
                    Problem.ShowResult();
                    break;

                case "1342": //1342. Number of Steps to Reduce a Number to Zero
                    Problem = new NumberofStepstoReduceaNumbertoZero();
                    Problem.ShowResult();
                    break;

                case "876": //876. Middle of the Linked List
                    Problem = new MiddleNode();
                    Problem.ShowResult();
                    break;

                case "383": //383. Ransom Note
                    Problem = new RansomNote();
                    Problem.ShowResult();
                    break;
                    
                case "Arrays101": //Arrays101. ALL
                    Problem = new Arrays101();
                    Problem.ShowResult();
                    break;

            }
            return;
        }
    }
}
