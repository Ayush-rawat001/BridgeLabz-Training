using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor.ExamProctor
{
    internal class Answer
    {
        private Dictionary<int, string> answers =
           new Dictionary<int, string>();

        public void SaveAnswer(int questionId, string answer)
        {
            answers[questionId] = answer;
        }

        public Dictionary<int, string> GetAnswers()
        {
            return answers;
        }
    }
}
