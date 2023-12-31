﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            lbProblems.Items.Clear();
            lbProblems.Items.Add("2235.Add Two Integers");
            lbProblems.Items.Add("2236.Root Equals Sum Of Children");
            lbProblems.Items.Add("1480.Running Sum of 1d Array");
            lbProblems.Items.Add("1672.Richest Customer Wealth");
            lbProblems.Items.Add("412. Fizz Buzz");
            lbProblems.Items.Add("1342. Number of Steps to Reduce a Number to Zero");
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
                    Problem = null;
                    return;

                case "2236": //2236.Root Equals Sum Of Children
                    Problem = new RootEqualsSumOfChildren();
                    Problem.ShowResult();
                    Problem = null;
                    return;

                case "1480": //1480.Running Sum of 1d Array
                    Problem = new RunningSumof1dArray();
                    Problem.ShowResult();
                    Problem = null;
                    return;

                case "1672": //1672.Richest Customer Wealth
                    Problem = new RichestCustomerWealth();
                    Problem.ShowResult();
                    Problem = null;
                    return;

                case "412": //412. Fizz Buzz
                    Problem = new FizzBuzz();
                    Problem.ShowResult();
                    Problem = null;
                    return;

                case "1342": //1342. Number of Steps to Reduce a Number to Zero
                    Problem = new NumberofStepstoReduceaNumbertoZero();
                    Problem.ShowResult();
                    Problem = null;
                    return;

            }
        }
    }
}
