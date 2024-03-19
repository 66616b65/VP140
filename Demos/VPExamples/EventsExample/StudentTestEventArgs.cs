using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class StudentTestEventArgs : EventArgs
    {
        public string TestName { get; }
        public int Score { get; }

        public StudentTestEventArgs(string testName, int score)
        {
            TestName = testName;
            Score = score;
        }
    }
}
