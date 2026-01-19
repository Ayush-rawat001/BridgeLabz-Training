using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor.ExamProctor
{
    internal class Evaluate
    {
        public int CalculateScore(
           List<Question> questions,
           Dictionary<int, string> answers)
        {
            int score = 0;

            foreach (Question q in questions)
            {
                if (answers.ContainsKey(q.id) &&
                    answers[q.id] == q.ans)
                {
                    score++;
                }
            }

            return score;
        }

    }
}
