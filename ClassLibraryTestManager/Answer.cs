using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibraryTestManager
{
    [Serializable]
    public class Answer
    {
        [JsonProperty("Text")]
        public string Text { get; set; }
        [JsonProperty("Correct")]
        public bool Correct { get; set; }
        [JsonProperty("Selected")]
        public bool Selected { get;set; }

        public Answer() : this("", false){ }
        public Answer(string text, bool correct)
        {
            Text = text;
            Correct = correct;
        }
        public Answer(Answer answer) : this(answer.Text, answer.Correct) { }
        public override string ToString() => Text;
        public override int GetHashCode() => Text.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is Answer ans) return ans.Text == Text;
            else return false;
        }
    }
}
