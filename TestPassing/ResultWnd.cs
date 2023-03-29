using ClassLibraryTestManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPassing
{
    public partial class ResultWnd : Form
    {
        private string TestName { get; set; }
        private TimeSpan TimeLeft { get; set; }
        private double MaxMark { get; set; }
        private double PassingMark { get; set; }
        private double Mark { get; set; }
        public ResultWnd(string testName, TimeSpan timeLeft, double maxMark, double passingMark, double mark)
        {
            TestName = testName;
            TimeLeft = timeLeft;
            MaxMark = maxMark;
            PassingMark = passingMark;
            Mark = mark;
            InitializeComponent();
        }
        public ResultWnd(Test test, double mark, TimeSpan timeleft)
            : this(test.Name, timeleft, test.GetMaxMark(), test.PassingScore, mark) { }

        private void ResultWnd_Load(object sender, EventArgs e)
        {
            if (Mark < PassingMark)
            {
                lbResult.ForeColor = Color.Red;
                lbResult.Text = "Failed";
            }
            else
            {
                lbResult.ForeColor = Color.Green;
                lbResult.Text = "Successful";
            }
            lbTestName.Text = $"Test: {TestName}";
            lbTime.Text = $"Time Left: {TimeLeft:c}";
            lbMaxMark.Text = $"Masimum Mark: {MaxMark}";
            lbPassingMark.Text = $"Passing Mark: {PassingMark}";
            lbResultMark.Text = $"Mark: {Mark}";
        }
    }
}
