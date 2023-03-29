namespace TextManager
{
    partial class TestManagerWnd
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
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.numPassScore = new System.Windows.Forms.NumericUpDown();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.gbQuestions = new System.Windows.Forms.GroupBox();
            this.numMark = new System.Windows.Forms.NumericUpDown();
            this.lbMark = new System.Windows.Forms.Label();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.btnRemoveAnswer = new System.Windows.Forms.Button();
            this.chCorrect = new System.Windows.Forms.CheckBox();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lbAnswers = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.gbQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).BeginInit();
            this.gbAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTest
            // 
            this.gbTest.BackColor = System.Drawing.SystemColors.Menu;
            this.gbTest.Controls.Add(this.lbMinutes);
            this.gbTest.Controls.Add(this.numPassScore);
            this.gbTest.Controls.Add(this.numTime);
            this.gbTest.Controls.Add(this.tbTitle);
            this.gbTest.Controls.Add(this.label1);
            this.gbTest.Controls.Add(this.lbTime);
            this.gbTest.Controls.Add(this.lbName);
            this.gbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTest.Location = new System.Drawing.Point(12, 12);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(529, 170);
            this.gbTest.TabIndex = 0;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "Test";
            // 
            // lbMinutes
            // 
            this.lbMinutes.Location = new System.Drawing.Point(228, 66);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(66, 24);
            this.lbMinutes.TabIndex = 3;
            this.lbMinutes.Text = "minutes";
            this.lbMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPassScore
            // 
            this.numPassScore.Location = new System.Drawing.Point(129, 104);
            this.numPassScore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPassScore.Name = "numPassScore";
            this.numPassScore.Size = new System.Drawing.Size(93, 24);
            this.numPassScore.TabIndex = 2;
            this.numPassScore.ValueChanged += new System.EventHandler(this.numPassScore_ValueChanged);
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(129, 66);
            this.numTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(93, 24);
            this.numTime.TabIndex = 2;
            this.numTime.ValueChanged += new System.EventHandler(this.numTime_ValueChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(129, 28);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(270, 24);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passing score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(6, 66);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(84, 23);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Time";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(6, 25);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Title";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbQuestions
            // 
            this.gbQuestions.Controls.Add(this.numMark);
            this.gbQuestions.Controls.Add(this.lbMark);
            this.gbQuestions.Controls.Add(this.btnRemoveQuestion);
            this.gbQuestions.Controls.Add(this.btnAddQuestion);
            this.gbQuestions.Controls.Add(this.tbQuestion);
            this.gbQuestions.Controls.Add(this.lbQuestions);
            this.gbQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbQuestions.Location = new System.Drawing.Point(12, 188);
            this.gbQuestions.Name = "gbQuestions";
            this.gbQuestions.Size = new System.Drawing.Size(254, 381);
            this.gbQuestions.TabIndex = 1;
            this.gbQuestions.TabStop = false;
            this.gbQuestions.Text = "Questions";
            // 
            // numMark
            // 
            this.numMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMark.Location = new System.Drawing.Point(47, 344);
            this.numMark.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numMark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMark.Name = "numMark";
            this.numMark.Size = new System.Drawing.Size(37, 24);
            this.numMark.TabIndex = 3;
            this.numMark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMark.ValueChanged += new System.EventHandler(this.numMark_ValueChanged);
            // 
            // lbMark
            // 
            this.lbMark.Location = new System.Drawing.Point(3, 346);
            this.lbMark.Name = "lbMark";
            this.lbMark.Size = new System.Drawing.Size(50, 22);
            this.lbMark.TabIndex = 4;
            this.lbMark.Text = "Mark";
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(90, 337);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(76, 36);
            this.btnRemoveQuestion.TabIndex = 2;
            this.btnRemoveQuestion.Text = "Remove";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(172, 337);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(76, 36);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(6, 267);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(242, 64);
            this.tbQuestion.TabIndex = 1;
            // 
            // lbQuestions
            // 
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.ItemHeight = 18;
            this.lbQuestions.Location = new System.Drawing.Point(6, 23);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(242, 238);
            this.lbQuestions.TabIndex = 0;
            this.lbQuestions.SelectedIndexChanged += new System.EventHandler(this.lbQuestions_SelectedIndexChanged);
            // 
            // gbAnswers
            // 
            this.gbAnswers.Controls.Add(this.btnRemoveAnswer);
            this.gbAnswers.Controls.Add(this.chCorrect);
            this.gbAnswers.Controls.Add(this.btnAddAnswer);
            this.gbAnswers.Controls.Add(this.tbAnswer);
            this.gbAnswers.Controls.Add(this.lbAnswers);
            this.gbAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAnswers.Location = new System.Drawing.Point(287, 188);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(254, 381);
            this.gbAnswers.TabIndex = 1;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Answers";
            // 
            // btnRemoveAnswer
            // 
            this.btnRemoveAnswer.Location = new System.Drawing.Point(88, 337);
            this.btnRemoveAnswer.Name = "btnRemoveAnswer";
            this.btnRemoveAnswer.Size = new System.Drawing.Size(76, 36);
            this.btnRemoveAnswer.TabIndex = 2;
            this.btnRemoveAnswer.Text = "Remove";
            this.btnRemoveAnswer.UseVisualStyleBackColor = true;
            this.btnRemoveAnswer.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chCorrect
            // 
            this.chCorrect.Location = new System.Drawing.Point(6, 344);
            this.chCorrect.Name = "chCorrect";
            this.chCorrect.Size = new System.Drawing.Size(87, 25);
            this.chCorrect.TabIndex = 3;
            this.chCorrect.Text = "Correct";
            this.chCorrect.UseVisualStyleBackColor = true;
            this.chCorrect.CheckedChanged += new System.EventHandler(this.chCorrect_CheckedChanged);
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(170, 337);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(78, 36);
            this.btnAddAnswer.TabIndex = 2;
            this.btnAddAnswer.Text = "Add";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(6, 267);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(242, 64);
            this.tbAnswer.TabIndex = 1;
            // 
            // lbAnswers
            // 
            this.lbAnswers.FormattingEnabled = true;
            this.lbAnswers.ItemHeight = 18;
            this.lbAnswers.Location = new System.Drawing.Point(6, 23);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(242, 238);
            this.lbAnswers.TabIndex = 0;
            this.lbAnswers.SelectedIndexChanged += new System.EventHandler(this.lbAnswers_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(433, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "json";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Json files(*.json)|*.json ";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Json files(*.json)|*.json ";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(12, 572);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 35);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // TestManagerWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 625);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.gbQuestions);
            this.Controls.Add(this.gbTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TestManagerWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestManager";
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.gbQuestions.ResumeLayout(false);
            this.gbQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).EndInit();
            this.gbAnswers.ResumeLayout(false);
            this.gbAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.NumericUpDown numPassScore;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbQuestions;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.ListBox lbAnswers;
        private System.Windows.Forms.CheckBox chCorrect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRemoveAnswer;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.NumericUpDown numMark;
        private System.Windows.Forms.Label lbMark;
    }
}

