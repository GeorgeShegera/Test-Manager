namespace TestPassing
{
    partial class MainWnd
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbText = new System.Windows.Forms.Label();
            this.lbTestName = new System.Windows.Forms.Label();
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.btnQuestion2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.btnQuestion4 = new System.Windows.Forms.Button();
            this.btnQuestion5 = new System.Windows.Forms.Button();
            this.btnQuestion6 = new System.Windows.Forms.Button();
            this.btnQuestion7 = new System.Windows.Forms.Button();
            this.btnQuestion8 = new System.Windows.Forms.Button();
            this.btnQuestion9 = new System.Windows.Forms.Button();
            this.btnQuestion10 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.rbAnswer5 = new System.Windows.Forms.RadioButton();
            this.chAnswer1 = new System.Windows.Forms.CheckBox();
            this.chAnswer2 = new System.Windows.Forms.CheckBox();
            this.chAnswer3 = new System.Windows.Forms.CheckBox();
            this.chAnswer4 = new System.Windows.Forms.CheckBox();
            this.chAnswer5 = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnСonfirm = new System.Windows.Forms.Button();
            this.lbPoints = new System.Windows.Forms.Label();
            this.lbCorAnswers = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(830, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smLoad});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // smLoad
            // 
            this.smLoad.Name = "smLoad";
            this.smLoad.Size = new System.Drawing.Size(100, 22);
            this.smLoad.Text = "Load";
            this.smLoad.Click += new System.EventHandler(this.smLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbText.Location = new System.Drawing.Point(12, 35);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(470, 35);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "To begin passing the test, open a file";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTestName
            // 
            this.lbTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTestName.Location = new System.Drawing.Point(6, 35);
            this.lbTestName.Name = "lbTestName";
            this.lbTestName.Size = new System.Drawing.Size(509, 35);
            this.lbTestName.TabIndex = 4;
            this.lbTestName.Text = "Test: ";
            this.lbTestName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Enabled = false;
            this.btnQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion1.Location = new System.Drawing.Point(11, 428);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion1.TabIndex = 5;
            this.btnQuestion1.Text = "1";
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Visible = false;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion2
            // 
            this.btnQuestion2.Enabled = false;
            this.btnQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion2.Location = new System.Drawing.Point(92, 428);
            this.btnQuestion2.Name = "btnQuestion2";
            this.btnQuestion2.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion2.TabIndex = 5;
            this.btnQuestion2.Text = "2";
            this.btnQuestion2.UseVisualStyleBackColor = true;
            this.btnQuestion2.Visible = false;
            this.btnQuestion2.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Enabled = false;
            this.btnQuestion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion3.Location = new System.Drawing.Point(173, 428);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion3.TabIndex = 5;
            this.btnQuestion3.Text = "3";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Visible = false;
            this.btnQuestion3.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion4
            // 
            this.btnQuestion4.Enabled = false;
            this.btnQuestion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion4.Location = new System.Drawing.Point(254, 428);
            this.btnQuestion4.Name = "btnQuestion4";
            this.btnQuestion4.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion4.TabIndex = 5;
            this.btnQuestion4.Text = "4";
            this.btnQuestion4.UseVisualStyleBackColor = true;
            this.btnQuestion4.Visible = false;
            this.btnQuestion4.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion5
            // 
            this.btnQuestion5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuestion5.Enabled = false;
            this.btnQuestion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion5.Location = new System.Drawing.Point(335, 428);
            this.btnQuestion5.Name = "btnQuestion5";
            this.btnQuestion5.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion5.TabIndex = 5;
            this.btnQuestion5.Text = "5";
            this.btnQuestion5.UseVisualStyleBackColor = false;
            this.btnQuestion5.Visible = false;
            this.btnQuestion5.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion6
            // 
            this.btnQuestion6.Enabled = false;
            this.btnQuestion6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion6.Location = new System.Drawing.Point(416, 428);
            this.btnQuestion6.Name = "btnQuestion6";
            this.btnQuestion6.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion6.TabIndex = 5;
            this.btnQuestion6.Text = "6";
            this.btnQuestion6.UseVisualStyleBackColor = true;
            this.btnQuestion6.Visible = false;
            this.btnQuestion6.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion7
            // 
            this.btnQuestion7.Enabled = false;
            this.btnQuestion7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion7.Location = new System.Drawing.Point(497, 428);
            this.btnQuestion7.Name = "btnQuestion7";
            this.btnQuestion7.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion7.TabIndex = 5;
            this.btnQuestion7.Text = "7";
            this.btnQuestion7.UseVisualStyleBackColor = true;
            this.btnQuestion7.Visible = false;
            this.btnQuestion7.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion8
            // 
            this.btnQuestion8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuestion8.Enabled = false;
            this.btnQuestion8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion8.Location = new System.Drawing.Point(578, 428);
            this.btnQuestion8.Name = "btnQuestion8";
            this.btnQuestion8.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion8.TabIndex = 5;
            this.btnQuestion8.Text = "8";
            this.btnQuestion8.UseVisualStyleBackColor = false;
            this.btnQuestion8.Visible = false;
            this.btnQuestion8.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion9
            // 
            this.btnQuestion9.Enabled = false;
            this.btnQuestion9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion9.Location = new System.Drawing.Point(659, 428);
            this.btnQuestion9.Name = "btnQuestion9";
            this.btnQuestion9.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion9.TabIndex = 5;
            this.btnQuestion9.Text = "9";
            this.btnQuestion9.UseVisualStyleBackColor = true;
            this.btnQuestion9.Visible = false;
            this.btnQuestion9.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnQuestion10
            // 
            this.btnQuestion10.Enabled = false;
            this.btnQuestion10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestion10.Location = new System.Drawing.Point(743, 428);
            this.btnQuestion10.Name = "btnQuestion10";
            this.btnQuestion10.Size = new System.Drawing.Size(75, 43);
            this.btnQuestion10.TabIndex = 5;
            this.btnQuestion10.Text = "10";
            this.btnQuestion10.UseVisualStyleBackColor = true;
            this.btnQuestion10.Visible = false;
            this.btnQuestion10.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(659, 379);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 43);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "→";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(11, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 43);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "←";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAnswer1.Location = new System.Drawing.Point(23, 142);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(800, 24);
            this.rbAnswer1.TabIndex = 7;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "The first answer";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            this.rbAnswer1.Visible = false;
            this.rbAnswer1.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // lbQuestion
            // 
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuestion.Location = new System.Drawing.Point(19, 83);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(634, 27);
            this.lbQuestion.TabIndex = 8;
            this.lbQuestion.Text = "№ The question..";
            this.lbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbQuestion.Visible = false;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAnswer2.Location = new System.Drawing.Point(23, 184);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(800, 24);
            this.rbAnswer2.TabIndex = 7;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "The second answer";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            this.rbAnswer2.Visible = false;
            this.rbAnswer2.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAnswer3.Location = new System.Drawing.Point(23, 226);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(800, 24);
            this.rbAnswer3.TabIndex = 7;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "The third answer";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            this.rbAnswer3.Visible = false;
            this.rbAnswer3.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAnswer4.Location = new System.Drawing.Point(23, 268);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(800, 24);
            this.rbAnswer4.TabIndex = 7;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "The fourth answer";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            this.rbAnswer4.Visible = false;
            this.rbAnswer4.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // rbAnswer5
            // 
            this.rbAnswer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAnswer5.Location = new System.Drawing.Point(23, 310);
            this.rbAnswer5.Name = "rbAnswer5";
            this.rbAnswer5.Size = new System.Drawing.Size(800, 24);
            this.rbAnswer5.TabIndex = 7;
            this.rbAnswer5.TabStop = true;
            this.rbAnswer5.Text = "The fifth answer";
            this.rbAnswer5.UseVisualStyleBackColor = true;
            this.rbAnswer5.Visible = false;
            this.rbAnswer5.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // chAnswer1
            // 
            this.chAnswer1.BackColor = System.Drawing.SystemColors.Control;
            this.chAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chAnswer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chAnswer1.Location = new System.Drawing.Point(23, 143);
            this.chAnswer1.Name = "chAnswer1";
            this.chAnswer1.Size = new System.Drawing.Size(800, 24);
            this.chAnswer1.TabIndex = 9;
            this.chAnswer1.Text = "The first answer";
            this.chAnswer1.UseVisualStyleBackColor = false;
            this.chAnswer1.Visible = false;
            this.chAnswer1.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // chAnswer2
            // 
            this.chAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chAnswer2.Location = new System.Drawing.Point(23, 184);
            this.chAnswer2.Name = "chAnswer2";
            this.chAnswer2.Size = new System.Drawing.Size(800, 24);
            this.chAnswer2.TabIndex = 9;
            this.chAnswer2.Text = "The second answer";
            this.chAnswer2.UseVisualStyleBackColor = true;
            this.chAnswer2.Visible = false;
            this.chAnswer2.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // chAnswer3
            // 
            this.chAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chAnswer3.Location = new System.Drawing.Point(23, 226);
            this.chAnswer3.Name = "chAnswer3";
            this.chAnswer3.Size = new System.Drawing.Size(800, 24);
            this.chAnswer3.TabIndex = 9;
            this.chAnswer3.Text = "The third answer";
            this.chAnswer3.UseVisualStyleBackColor = true;
            this.chAnswer3.Visible = false;
            this.chAnswer3.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // chAnswer4
            // 
            this.chAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chAnswer4.Location = new System.Drawing.Point(23, 268);
            this.chAnswer4.Name = "chAnswer4";
            this.chAnswer4.Size = new System.Drawing.Size(800, 24);
            this.chAnswer4.TabIndex = 9;
            this.chAnswer4.Text = "The fourth answer";
            this.chAnswer4.UseVisualStyleBackColor = true;
            this.chAnswer4.Visible = false;
            this.chAnswer4.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // chAnswer5
            // 
            this.chAnswer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chAnswer5.Location = new System.Drawing.Point(23, 310);
            this.chAnswer5.Name = "chAnswer5";
            this.chAnswer5.Size = new System.Drawing.Size(800, 24);
            this.chAnswer5.TabIndex = 9;
            this.chAnswer5.Text = "The fifth answer";
            this.chAnswer5.UseVisualStyleBackColor = true;
            this.chAnswer5.Visible = false;
            this.chAnswer5.CheckedChanged += new System.EventHandler(this.chAnswer_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbTimer
            // 
            this.tbTimer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTimer.Enabled = false;
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTimer.Location = new System.Drawing.Point(659, 33);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(159, 31);
            this.tbTimer.TabIndex = 10;
            this.tbTimer.Tag = "";
            this.tbTimer.Text = "00:00:00";
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(254, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 43);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnСonfirm
            // 
            this.btnСonfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnСonfirm.Location = new System.Drawing.Point(416, 379);
            this.btnСonfirm.Name = "btnСonfirm";
            this.btnСonfirm.Size = new System.Drawing.Size(156, 43);
            this.btnСonfirm.TabIndex = 12;
            this.btnСonfirm.Text = "✓";
            this.btnСonfirm.UseVisualStyleBackColor = true;
            this.btnСonfirm.Visible = false;
            this.btnСonfirm.Click += new System.EventHandler(this.btnСonfirm_Click);
            // 
            // lbPoints
            // 
            this.lbPoints.BackColor = System.Drawing.Color.Gainsboro;
            this.lbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPoints.Location = new System.Drawing.Point(659, 79);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(159, 31);
            this.lbPoints.TabIndex = 13;
            this.lbPoints.Text = "15,75 out of 30 points";
            this.lbPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPoints.Visible = false;
            // 
            // lbCorAnswers
            // 
            this.lbCorAnswers.BackColor = System.Drawing.Color.Gainsboro;
            this.lbCorAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCorAnswers.Location = new System.Drawing.Point(659, 348);
            this.lbCorAnswers.Name = "lbCorAnswers";
            this.lbCorAnswers.Size = new System.Drawing.Size(159, 28);
            this.lbCorAnswers.TabIndex = 14;
            this.lbCorAnswers.Text = "Correct answers: 2";
            this.lbCorAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 483);
            this.Controls.Add(this.lbCorAnswers);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.btnСonfirm);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnQuestion10);
            this.Controls.Add(this.btnQuestion9);
            this.Controls.Add(this.btnQuestion8);
            this.Controls.Add(this.btnQuestion7);
            this.Controls.Add(this.btnQuestion6);
            this.Controls.Add(this.btnQuestion5);
            this.Controls.Add(this.btnQuestion4);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.btnQuestion2);
            this.Controls.Add(this.btnQuestion1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.chAnswer3);
            this.Controls.Add(this.chAnswer2);
            this.Controls.Add(this.chAnswer1);
            this.Controls.Add(this.chAnswer5);
            this.Controls.Add(this.chAnswer4);
            this.Controls.Add(this.rbAnswer1);
            this.Controls.Add(this.rbAnswer2);
            this.Controls.Add(this.rbAnswer3);
            this.Controls.Add(this.rbAnswer5);
            this.Controls.Add(this.rbAnswer4);
            this.Controls.Add(this.lbTestName);
            this.Controls.Add(this.lbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Passing";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbTestName;
        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.Button btnQuestion2;
        private System.Windows.Forms.Button btnQuestion3;
        private System.Windows.Forms.Button btnQuestion4;
        private System.Windows.Forms.Button btnQuestion5;
        private System.Windows.Forms.Button btnQuestion6;
        private System.Windows.Forms.Button btnQuestion7;
        private System.Windows.Forms.Button btnQuestion8;
        private System.Windows.Forms.Button btnQuestion9;
        private System.Windows.Forms.Button btnQuestion10;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.RadioButton rbAnswer5;
        private System.Windows.Forms.CheckBox chAnswer1;
        private System.Windows.Forms.CheckBox chAnswer2;
        private System.Windows.Forms.CheckBox chAnswer3;
        private System.Windows.Forms.CheckBox chAnswer4;
        private System.Windows.Forms.CheckBox chAnswer5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnСonfirm;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label lbCorAnswers;
    }
}

