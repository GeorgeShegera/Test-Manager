using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace ClassLibraryTestManager
{
    [Serializable]
    public class Question
    {
        [JsonProperty("Text")]
        public string Text { get; set; }

        [JsonProperty("Mark")]
        public int Mark { get; set; }

        [JsonProperty("Answered")]
        public bool Answered { get; set; } = false;

        public Question(string text, int mark)
        { 
            Text = text;
            Mark = mark;
        }
        public Question(Question question) : this(question.Text, question.Mark) { }
        public Question() : this("", 1) { }

        public override string ToString() => Text;
        public override int GetHashCode() => Text.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is Question question) return question.Text == Text;
            else return false;
        }
    }
}
