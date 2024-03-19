using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class Student
    {
        public string Name { get; private set; }
        public int Group { get; private set; }

        //public delegate void StudentTestEvent(StudentTestEventArgs testResult);
        public delegate void StudentTestEvent(string testName, int score);

        public event StudentTestEvent OnSomeTest;
        //public event StudentTestEvent2 OnSomeTest2;

        public event EventHandler<StudentTestEventArgs> OnTest;

        public Student (string name, int group)
        {
            Name = name;
            Group = group;
        }

        public void Test(string testName, int score)
        {
            OnTest?.Invoke(this, new StudentTestEventArgs(testName, score));

            //OnSomeTest?.Invoke(new StudentTestEventArgs(testName, score));

            OnSomeTest?.Invoke(testName, score);
        }


    }
}
