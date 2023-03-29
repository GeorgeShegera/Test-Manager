using ClassLibraryTestManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace TextManager
{
    [Serializable]
    public partial class TestManagerWnd : Form
    {
        [JsonProperty("Test")]
        private Test test = new Test();
        private Question SelectedQuestion => test.GetQuestion(lbQuestions.SelectedItem?.ToString());
        public TestManagerWnd()
        {
            InitializeComponent();
        }

        private Answer GetSelectedAnswer()
        {
            if (lbAnswers.SelectedItem != null)
            {
                List<Answer> answers = new List<Answer>(test[SelectedQuestion]);
                foreach (Answer answer in answers)
                {
                    if (answer.Text == lbAnswers.SelectedItem.ToString()) return answer;
                }
            }
            return null;
        }

        private void ErrorMessage(string text) =>
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private bool CheckSelectedAnswer() => lbAnswers.SelectedIndex != -1;

        private void DefineBoxItems(out TextBox textBox, out ListBox listBox, bool isAnswer)
        {
            textBox = isAnswer ? tbAnswer : tbQuestion;
            listBox = isAnswer ? lbAnswers : lbQuestions;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isAnswer = (sender as Button).Name == btnAddAnswer.Name;
            DefineBoxItems(out TextBox textBox, out ListBox listBox, isAnswer);
            string text = isAnswer ? textBox.Text : textBox.Text;
            if (text == "")
            {
                ErrorMessage("You have to fill the text field");
                return;
            }
            if (!isAnswer)
            {
                if (test.GetQuestions().Any(x => x.Text == text))
                {
                    ErrorMessage("This question has already been added");
                    return;
                }
                test.Tasks.Add(new Question(text, (int)numMark.Value), new List<Answer>());
                numMark.Value = numMark.Minimum;                
            }
            else
            {
                if (lbQuestions.Items.Count == 0)
                {
                    ErrorMessage("There are not questions");
                    return;
                }
                else if (SelectedQuestion == null)
                {
                    ErrorMessage("You have to select question");
                    return;
                }
                else if(lbAnswers.Items.Count == 5)
                {
                    ErrorMessage("You can't create more than five answers");
                    return;
                }
                else if (test[SelectedQuestion].Any(x => x.Text == text))
                {
                    ErrorMessage("This answer has already been added");
                    return;
                }         
                test.AddAnswer(SelectedQuestion, new Answer(text, chCorrect.Checked));
                Answer selectedAnsw = GetSelectedAnswer();
                chCorrect.Checked = false;
            }
            listBox.SelectedIndex = -1;
            listBox.Items.Add(text);            
            textBox.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool isAnswer = (sender as Button).Name == btnRemoveAnswer.Name;
            DefineBoxItems(out TextBox textBox, out ListBox listBox, isAnswer);
            if (textBox.Text != "")
            {
                textBox.Clear();
                return;
            }
            else if (listBox.Items.Count == 0)
            {
                ErrorMessage($"There are not {(isAnswer ? "answers" : "qustions")}");
                return;
            }
            Question selectedQuestion = SelectedQuestion;
            int index;
            if (isAnswer)
            {
                Answer selectedAnswer = GetSelectedAnswer();
                if (selectedAnswer is null)
                {
                    ErrorMessage("You have to select a question");
                    return;
                }
                index = listBox.Items.IndexOf(selectedAnswer.Text);
                listBox.Items.Remove(selectedAnswer.Text);
                test[selectedQuestion].Remove(selectedAnswer);
            }
            else
            {
                if (SelectedQuestion is null)
                {
                    ErrorMessage("You have to select a question");
                    return;
                }
                index = listBox.Items.IndexOf(selectedQuestion.ToString());
                test.Tasks.Remove(selectedQuestion);
                listBox.Items.Remove(selectedQuestion.ToString());
            }
            index = index > 0 ? index - 1 : 0;
            listBox.SelectedIndex = listBox.Items.Count != 0 ? index : -1;
        }

        private void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAnswers.Items.Clear();
            if (SelectedQuestion is null) return;
            numMark.Value = SelectedQuestion.Mark;
            foreach (Answer answer in test[SelectedQuestion])
                lbAnswers.Items.Add(answer.Text);
        }

        private void chCorrect_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckSelectedAnswer() || tbAnswer.Text != "") return;
            GetSelectedAnswer().Correct = chCorrect.Checked;
        }
        private void numMark_ValueChanged(object sender, EventArgs e)
        {
            if (lbQuestions.SelectedIndex == -1 || tbQuestion.Text != "") return;
            SelectedQuestion.Mark = (int)numMark.Value;
        }

        private void lbAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CheckSelectedAnswer()) return;
            chCorrect.Checked = GetSelectedAnswer().Correct;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbQuestions.Items.Count == 0)
            {
                ErrorMessage("You must add at least one answer");
                return;
            }
            else if(tbTitle.Text == "")
            {
                ErrorMessage("You must fill the Title field");
                return;
            }
            else if(numTime.Value == 0)
            {
                ErrorMessage("You must fill the Time field");
                return;
            }
            List<Question> questions = test.GetQuestions();
            foreach (Question question in questions)
            {
                if (test[question].Count < 2)
                {
                    ErrorMessage("There are not enogth answers");
                    return;
                }
                bool correctAnswer = false;
                foreach (Answer answer in test[question])
                {
                    correctAnswer = answer.Correct;
                    if (correctAnswer) break;
                }
                if (!correctAnswer)
                {
                    ErrorMessage("There is a question without correct answer");
                    return;
                }
            }
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string json = JsonConvert.SerializeObject(test);
            using (Stream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    writer.WriteLine(json);
            }
            MessageBox.Show("Test has been saved");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Json files(*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string json = "";
            using (Stream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                        json += reader.ReadLine() + "\n";
                }
            }
            test = JsonConvert.DeserializeObject<Test>(json);
            tbTitle.Text = test.Name;
            numTime.Value = (decimal)test.Time.TotalMinutes;
            numPassScore.Value = test.PassingScore;
            lbQuestions.Items.Clear();
            lbAnswers.Items.Clear(); 
            foreach (Question question in test.Tasks.Keys)
                lbQuestions.Items.Add(question.Text);
        }

        private void tbTitle_TextChanged(object sender, EventArgs e) =>
            test.Name = tbTitle.Text;

        private void numTime_ValueChanged(object sender, EventArgs e) =>
            test.Time = TimeSpan.FromMinutes((int)numTime.Value);

        private void numPassScore_ValueChanged(object sender, EventArgs e)
        {
            double maxMark = test.GetMaxMark();
            if (maxMark < (double)(sender as NumericUpDown).Value)
            {
                ErrorMessage($"The passing score can't be bigger than max mark: {maxMark}");
                (sender as NumericUpDown).Value = 0;
                return;
            }
            test.PassingScore = (int)numPassScore.Value;
        }
    }
}
