using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTestManager;
using Newtonsoft.Json;

namespace TestPassing
{
    public partial class MainWnd : Form
    {
        private Test test = null;
        private List<Button> QuestionBtns { get; set; }
        private List<RadioButton> AnswersRb { get; set; }
        private List<CheckBox> AnswersCh { get; set; }
        private int ScrollNumber { get; set; } = 0;
        private TimeSpan TestTime { get; set; }
        private List<double> Points { get; set; }
        private Button SelectedQuestionBtn { get; set; } = null;
        private bool chError { get; set; } = false;
        public MainWnd()
        {
            InitializeComponent();
            lbTestName.Visible = false;
            Size = new Size(509, 120);
            QuestionBtns = new List<Button>
            {
                btnQuestion1,
                btnQuestion2,
                btnQuestion3,
                btnQuestion4,
                btnQuestion5,
                btnQuestion6,
                btnQuestion7,
                btnQuestion8,
                btnQuestion9,
                btnQuestion10
            };
            AnswersRb = new List<RadioButton>
            {
                rbAnswer1,
                rbAnswer2,
                rbAnswer3,
                rbAnswer4,
                rbAnswer5
            };
            AnswersCh = new List<CheckBox>
            {
                chAnswer1,
                chAnswer2,
                chAnswer3,
                chAnswer4,
                chAnswer5
            };
        }

        private void smLoad_Click(object sender, EventArgs e)
        {
            if (btnStart.Visible == false && (test != null && !test.Complete()))
            {
                DialogResult res = WarningMessange("If you change the file you will lose your progress");
                if (res == DialogResult.Cancel) return;
            }
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string json = "";
            using (Stream steam = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(steam, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        json += reader.ReadLine();
                    }
                }
            }
            test = JsonConvert.DeserializeObject<Test>(json);
            Size = new Size(846, 522);
            CenterToScreen();
            Controls.Remove(lbText);
            lbTestName.Visible = true;
            lbTestName.Text = $"Test: {test.Name}";
            int questBtnCount = QuestionBtns.Count;
            int questCount = test.TasksCount();
            btnNext.Visible = questCount > questBtnCount;
            btnBack.Visible = false;
            btnStart.Visible = true;
            btnNext.Enabled = false;
            HideCurQuestion();
            for (int i = 0; i < QuestionBtns.Count; i++)
            {
                QuestionBtns[i].Text = (i + 1).ToString();
                QuestionBtns[i].BackColor = SystemColors.ControlLight;
                QuestionBtns[i].Enabled = false;
            }
            for (int i = 0; i < questBtnCount; i++)
                QuestionBtns[i].Visible = i < questCount;
            TestTime = test.Time;
            Points = new List<double>(new double[questCount]);
            timer.Stop();
            RefreshTimer();
        }
        private void HideCurQuestion()
        {
            HideAnswers(AnswersCh);
            HideAnswers(AnswersRb);
            lbPoints.Visible = false;
            lbCorAnswers.Visible = false;
            lbQuestion.Visible = false;
            btnСonfirm.Visible = false;
        }
        private void RefreshTimer() => tbTimer.Text = $"{TestTime:c}";
        private int GetSelQuestIndex() => Convert.ToInt32(SelectedQuestionBtn.Text) - 1;
        public DialogResult WarningMessange(string messange)
            => MessageBox.Show(messange, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        private List<ButtonBase> GetBtnAnswers(bool isMultipleAnswer)
        {
            List<ButtonBase> buttons = new List<ButtonBase>();
            if (isMultipleAnswer) buttons.AddRange(AnswersCh);
            else buttons.AddRange(AnswersRb);
            return buttons;
        }

        private List<ButtonBase> GetCheckedBtns(List<Answer> answers, bool isMultAnswer)
        {
            List<ButtonBase> buttons = new List<ButtonBase>();
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].Selected)
                {
                    if (isMultAnswer) buttons.Add(AnswersCh[i]);
                    else buttons.Add(AnswersRb[i]);
                }
            }
            return buttons;
        }

        private void SetQuestionColor(Button btnQuestion, Question question, double mark)
        {
            Color color;
            double maxMark = question.Mark;
            if (!question.Answered) color = SystemColors.Control;
            else if (mark == maxMark) color = Color.GreenYellow;
            else if (mark >= maxMark / 2) color = Color.Yellow;
            else if (mark < maxMark / 2 && mark != 0) color = Color.Orange;
            else color = Color.LightPink;
            btnQuestion.BackColor = color;
        }

        private void RefreshLbPoints(Question question, double mark)
        {
            lbPoints.Visible = question.Answered;
            if (!question.Answered) return;
            lbPoints.Text = $"{Math.Round(mark, 2)} out of {question.Mark}";
        }
        private void RefreshLbCorAnswers(int number) =>
            lbCorAnswers.Text = $"Correct answers: {number}";

        private void btnArrow_Click(object sender, EventArgs e)
        {
            lbPoints.Visible = false;
            lbCorAnswers.Visible = false;
            bool isNextBtn = (sender as Button) == btnNext;
            Button oppArrowBtn = isNextBtn ? btnBack : btnNext;
            oppArrowBtn.Visible = true;
            ScrollNumber += isNextBtn ? 1 : -1;
            int questionNum = ScrollNumber * QuestionBtns.Count + 1;
            bool visible;
            HideCurQuestion();
            for (int i = 0; i < QuestionBtns.Count; i++)
            {
                QuestionBtns[i].Text = questionNum.ToString();
                visible = questionNum <= test.TasksCount();
                QuestionBtns[i].Visible = visible;
                if (visible) SetQuestionColor(QuestionBtns[i], test[questionNum - 1], Points[questionNum - 1]);
                questionNum++;
            }
            if (isNextBtn)
                (sender as Button).Visible = test.TasksCount() > Convert.ToInt32(QuestionBtns.Last().Text);
            else
                (sender as Button).Visible = ScrollNumber != 0;
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            btnСonfirm.Visible = true;
            SelectedQuestionBtn = sender as Button;
            lbQuestion.Visible = true;
            int index = GetSelQuestIndex();
            Question question = test.GetQuestions()[index];
            btnСonfirm.Enabled = !question.Answered;
            lbQuestion.Text = $"{index + 1}. {question.Text}";
            RefreshLbPoints(question, Points[index]);
            RefreshAnswers(question);
        }

        private void btnСonfirm_Click(object sender, EventArgs e)
        {
            int index = GetSelQuestIndex();
            Question question = test.GetQuestions()[index];
            List<Answer> corAnswers = test.GetCorAnsws(question);
            bool isMultAnswer = corAnswers.Count > 1;
            List<ButtonBase> selectedAnswers = GetCheckedBtns(test[question], isMultAnswer);
            if (selectedAnswers.Count == 0)
            {
                MessageBox.Show("You must select at least one answer", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Answer answer in test[question])
            {
                if (selectedAnswers.Any(x => x.Text == answer.Text))
                {
                    int dividend = corAnswers.Count;
                    if (!answer.Correct) dividend *= -1;
                    Points[index] += (double)question.Mark / dividend;
                }
            }
            if (Points[index] < 0) Points[index] = 0;
            question.Answered = true;
            btnСonfirm.Enabled = false;
            RefreshLbPoints(question, Points[index]);
            RefreshAnswers(question);
            SetQuestionColor(SelectedQuestionBtn, question, Points[index]);
            if (test.Complete()) EndOfTest();
        }

        private void RefreshAnswers(Question selQuestion)
        {
            bool answered = selQuestion.Answered;
            List<Answer> answers = test[selQuestion];
            List<Answer> corAnswers = test.GetCorAnsws(selQuestion);
            bool isMultAnswer = corAnswers.Count > 1;
            lbCorAnswers.Visible = isMultAnswer && !selQuestion.Answered;
            RefreshLbCorAnswers(corAnswers.Count);
            List<ButtonBase> answersBtns = GetBtnAnswers(isMultAnswer);
            if (isMultAnswer) HideAnswers(AnswersRb);
            else HideAnswers(AnswersCh);
            DisplayAnswers(answersBtns, answers);
            bool isChecked;
            for (int i = 0; i < answersBtns.Count; i++)
            {
                answersBtns[i].Enabled = !answered;
                answersBtns[i].BackColor = SystemColors.Control;
                if (answersBtns[i].Visible)
                {
                    isChecked = test[selQuestion][i].Selected;
                    if (isMultAnswer) AnswersCh[i].Checked = isChecked;
                    else AnswersRb[i].Checked = isChecked;
                }
            }
            if (!answered) return;
            List<ButtonBase> checkedBtns = GetCheckedBtns(answers, isMultAnswer);
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i].Correct) answersBtns[i].BackColor = Color.GreenYellow;
                else if (checkedBtns.Any(x => x.Text == answers[i].Text))
                    answersBtns[i].BackColor = Color.LightPink;
            }
        }

        private void DisplayAnswers<T>(List<T> btnAnswers, List<Answer> answers)
            where T : ButtonBase
        {
            bool answInRange;
            for (int i = 0; i < btnAnswers.Count; i++)
            {
                answInRange = i < answers.Count;
                if (answInRange) btnAnswers[i].Text = answers[i].Text;
                btnAnswers[i].Visible = answInRange;
            }
        }

        private void HideAnswers<T>(List<T> btnAnswers) where T : ButtonBase
        {
            for (int i = 0; i < btnAnswers.Count; i++)
                btnAnswers[i].Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (WarningMessange("Are you ready to begin the test?") == DialogResult.Cancel) return;
            timer.Start();
            btnStart.Visible = false;
            foreach (Button button in QuestionBtns)
                button.Enabled = true;
            btnNext.Enabled = true;            
        }

        private void timer_Tick(object sender, EventArgs e)
        {            
            if (TestTime.TotalSeconds <= 0) EndOfTest();
            else
            {
                TestTime -= new TimeSpan(0, 0, 1);
                RefreshTimer();
            }
        }

        private void chAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (chError)
            {
                chError = false;
                return;
            }
            Question question = test[GetSelQuestIndex()];
            List<Answer> answers = test[question];
            foreach (Answer answer in answers)
            {
                if (answer.Text == (sender as ButtonBase).Text)
                {
                    if (sender is CheckBox checkBox)
                    {
                        answer.Selected = checkBox.Checked;
                        if (test.GetCorAnsws(question).Count < GetCheckedBtns(answers, true).Count)
                        {
                            chError = true;
                            checkBox.Checked = false;
                            answer.Selected = false;
                            MessageBox.Show("You can't select more than number of correct answers",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else answer.Selected = (sender as RadioButton).Checked;
                    return;
                }
            }
        }

        private void EndOfTest()
        {
            timer.Stop();
            foreach (Question question in test.Tasks.Keys) question.Answered = true;
            double resMark = 0;
            foreach (double mark in Points) resMark += mark;
            ResultWnd resultWnd = new ResultWnd(test, Math.Round(resMark, 2), TestTime);
            resultWnd.ShowDialog();
        }
    }
}
