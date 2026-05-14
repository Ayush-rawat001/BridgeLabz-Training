using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor.ExamProctor
{
    internal class Navigation
    {
        private Stack<int> stack = new Stack<int>();

        public void Visit(int questionId)
        {
            stack.Push(questionId);
        }

        public int GoBack()
        {
            if (stack.Count > 0)
                return stack.Pop();

            return -1;
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
    }
}
