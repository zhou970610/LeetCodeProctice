using System;
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
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if(lbProblems.SelectedIndex == -1)
            {
                MessageBox.Show("Didn't Select a Problem.","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string[] SelectedProblem = lbProblems.SelectedItem.ToString().Split('.');

            switch (SelectedProblem[0])
            {
                case "2235": //Add Two Integers
                    AddTwoIntegers Problem = new AddTwoIntegers();
                    Problem.ShowResult();
                    Problem = null;
                    return;

            }
        }
    }
}
