namespace TestPassing
{
    partial class ResultWnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbResult = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbResultMark = new System.Windows.Forms.Label();
            this.lbPassingMark = new System.Windows.Forms.Label();
            this.lbMaxMark = new System.Windows.Forms.Label();
            this.lbTestName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.Location = new System.Drawing.Point(12, 9);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(497, 41);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Result";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(13, 106);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(250, 35);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Time left: 00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbResultMark
            // 
            this.lbResultMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResultMark.Location = new System.Drawing.Point(13, 245);
            this.lbResultMark.Name = "lbResultMark";
            this.lbResultMark.Size = new System.Drawing.Size(250, 35);
            this.lbResultMark.TabIndex = 0;
            this.lbResultMark.Text = "Mark: 10,23";
            this.lbResultMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPassingMark
            // 
            this.lbPassingMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassingMark.Location = new System.Drawing.Point(12, 200);
            this.lbPassingMark.Name = "lbPassingMark";
            this.lbPassingMark.Size = new System.Drawing.Size(250, 35);
            this.lbPassingMark.TabIndex = 0;
            this.lbPassingMark.Text = "Passing Mark: 8,87";
            this.lbPassingMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMaxMark
            // 
            this.lbMaxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxMark.Location = new System.Drawing.Point(12, 154);
            this.lbMaxMark.Name = "lbMaxMark";
            this.lbMaxMark.Size = new System.Drawing.Size(250, 35);
            this.lbMaxMark.TabIndex = 0;
            this.lbMaxMark.Text = "Masimum Mark: 12,44";
            this.lbMaxMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTestName
            // 
            this.lbTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTestName.Location = new System.Drawing.Point(12, 61);
            this.lbTestName.Name = "lbTestName";
            this.lbTestName.Size = new System.Drawing.Size(250, 35);
            this.lbTestName.TabIndex = 0;
            this.lbTestName.Text = "Test: Name";
            this.lbTestName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResultWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 289);
            this.Controls.Add(this.lbMaxMark);
            this.Controls.Add(this.lbPassingMark);
            this.Controls.Add(this.lbResultMark);
            this.Controls.Add(this.lbTestName);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ResultWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.ResultWnd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbResultMark;
        private System.Windows.Forms.Label lbPassingMark;
        private System.Windows.Forms.Label lbMaxMark;
        private System.Windows.Forms.Label lbTestName;
    }
}