namespace LeetCode
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProblems = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProblems
            // 
            this.lbProblems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbProblems.FormattingEnabled = true;
            this.lbProblems.ItemHeight = 16;
            this.lbProblems.Location = new System.Drawing.Point(18, 32);
            this.lbProblems.Margin = new System.Windows.Forms.Padding(4);
            this.lbProblems.Name = "lbProblems";
            this.lbProblems.Size = new System.Drawing.Size(318, 548);
            this.lbProblems.Sorted = true;
            this.lbProblems.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Problems:";
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(343, 32);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(165, 52);
            this.btnDo.TabIndex = 2;
            this.btnDo.Text = "Execute";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 600);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbProblems);
            this.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProblems;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDo;
    }
}

