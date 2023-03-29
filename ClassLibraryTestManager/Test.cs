using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClassLibraryTestManager
{
    [Serializable]
    public class Test
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Time")]
        public TimeSpan Time { get; set; }
        [JsonProperty("PassingScore")]
        public int PassingScore { get; set; }
        [JsonProperty("Tasks")]
        public Dictionary<Question, List<Answer>> Tasks { get; set; }

        public Test()
        {
            Name = "";
            Time = TimeSpan.Zero;
            PassingScore = 0;
            Tasks = new Dictionary<Question, List<Answer>>();
        }
        public int TasksCount() => Tasks.Count;
        public double GetMaxMark()
        {
            double result = 0;
            foreach (Question question in Tasks.Keys)
            {
                result += question.Mark;
            }
            return result;
        }
        public Question GetQuestion(string name)
        {
            foreach (Question question in Tasks.Keys)
            {
                if (name == question.Text) return question;
            }
            return null;
        }
        public bool Complete() => !Tasks.Keys.Any(x => !x.Answered);        
        public List<Question> GetQuestions() => new List<Question>(Tasks.Keys);
        public void AddAnswer(Question key, Answer answer) => Tasks[key].Add(answer);
        public List<Answer> GetCorAnsws()
        {
            List<Answer> result = new List<Answer>();
            foreach (Question question in Tasks.Keys)
            {
                result.AddRange(Tasks[question].Where(x => x.Correct).ToList());
            }
            return result;
        }
        public List<Answer> GetCorAnsws(Question question)
            => Tasks[question].Where(x => x.Correct).ToList();
        public List<Answer> this[Question question]
        {
            set { Tasks[question] = value; }
            get { return Tasks[question]; }
        }
        public Question this[int index]
        {
            set { Tasks.Keys[index] = value; }
            get { return Tasks.Keys[index]; }
        }
    }
}
